using Elecciones.Datos;
using Elecciones.Modelos;
using Plugin.DeviceInfo;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Linq;
using Acr.UserDialogs;
using Plugin.Connectivity;

namespace Elecciones.ViewModels
{
    public class SondeViewModel : ViewModelBase
    {
        public SondeViewModel()
        {
            AsignarIdsPublicidad();
            IsDevice = CrossDeviceInfo.Current.IsDevice;
            ConsultarSenso();
        }

        private bool isdevice;

        public bool IsDevice
        {
            get { return isdevice; }
            set
            {
                isdevice = value;
                OnPropertyChanged("IsDevice");
            }
        }

        private void AsignarIdsPublicidad()
        {
            if (Device.RuntimePlatform == Device.iOS)
                IdBanner = "ca-app-pub-2325431808910219/2930234497";
            else if (Device.RuntimePlatform == Device.Android)
                IdBanner = "ca-app-pub-2325431808910219/6021563589";
            else if (Device.RuntimePlatform == Device.UWP)
                IdBanner = "1100018256";
        }
        private string idBanner;

        public string IdBanner
        {
            get { return idBanner; }
            set
            {
                idBanner = value;
                OnPropertyChanged("IdBanner");
            }
        }


        private ObservableCollection<Senso> candidatos;

        public ObservableCollection<Senso> Candidatos
        {
            get { return candidatos; }
            set
            {
                candidatos = value;
                OnPropertyChanged("Candidatos");
            }
        }

        public Senso CandidatoSeleccionado { get; set; }

        /// <summary>
        /// Votars this instance.
        /// </summary>
        public async void Votar()
        {
            if (CandidatoSeleccionado != null && IsDevice)
            {
                if (CrossConnectivity.Current.IsConnected)
                {
                    bool voto = await VotarAzure();
                    if (voto)
                    {
                        Notificar("Voto guardado correctamente, Comparte la APP para tener mas votos!!");
                        ConsultarSenso();
                    }
                    else
                    {
                        Mensaje("No fue posible conectar con el servidor, intente de nuevo.");
                    }
                }
                else
                    Mensaje("Esta opción necesita conexion a internet, Revise conexión e intente de nuevo");
            }
            else
            {
                Notificar("Seleccione el candidato por el que va a votar!");
            }
        }

        public static void Notificar(string mensaje)
        {
            UserDialogs.Instance.Toast(mensaje, TimeSpan.FromMilliseconds(4000));
        }

        public static void Mensaje(string mensaje)
        {
            UserDialogs.Instance.Alert(new AlertConfig() { Message = mensaje, Title = "Elecciones" });
        }

        public async void ConsultarSenso()
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                using (IProgressDialog progress = UserDialogs.Instance.Loading("Consultando Votos..", null, null, true, MaskType.Black))
                {

                    List<Candidato> candidatosApp = Repositorio.GetCandidatos();
                    List<Senso> sensos = await ConsultarSensoAzure();
                    if (sensos != null)
                    {
                        Candidato candidato;
                        foreach (var senso in sensos)
                        {
                            candidato = candidatosApp.FirstOrDefault(c => c.Id == senso.IdCandidato);
                            if (senso.Cantidad > 0)
                                senso.Porcentaje = string.Format("{0} %", Math.Round(((Convert.ToDecimal(senso.Cantidad) / Convert.ToDecimal(sensos.Sum(c => c.Cantidad))) * 100), 2));
                            senso.DescripcionCantidad = string.Format("{0} Votos", senso.Cantidad);
                            senso.Foto = candidato.Foto;
                            senso.Nombre = candidato.Nombre;
                        }

                        Candidatos = new ObservableCollection<Senso>(sensos.OrderByDescending(s => s.Cantidad));
                    }
                    else
                        Mensaje("No fue posible conectar con el servidor, intente de nuevo.");
                }
            }
            else
                Mensaje("Esta opción necesita conexion a internet, Revise conexión e intente de nuevo");
        }

        public async Task<List<Senso>> ConsultarSensoAzure()
        {
            var client = new RestClient("https://eleccionescolombia.azurewebsites.net/api/HttpTriggerCSharp2?code=P34m77Sq9IBVxPsBuINZTan5q2vNLp57uRfdU0BDreMApraeGT6Glg==");
            var request = new RestRequest("", Method.GET);
            var response = await client.ExecuteGetTaskAsync<List<Senso>>(request);
            if (response.ResponseStatus == ResponseStatus.Completed)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
                    return null;
                return response.Data;
            }
            else
                return null;
        }


        public async Task<bool> VotarAzure()
        {
            using (IProgressDialog progress = UserDialogs.Instance.Loading("Guardando Voto..", null, null, true, MaskType.Black))
            {
                var client = new RestClient("https://eleccionescolombia.azurewebsites.net/api/HttpTriggerCSharp1?code=/rADc6yrO7F2N6lm/C4Ztnz22u0naBlL/K5pOfPgYZJ4avN5c5DEfQ==");
                var request = new RestRequest("", Method.POST);
                Voto voto = new Voto();
                voto.llave = CrossDeviceInfo.Current.Id;
                voto.id = CandidatoSeleccionado.IdCandidato;
                voto.usuario = CrossDeviceInfo.Current.Id;
                request.AddJsonBody(voto);
                var response = await client.ExecutePostTaskAsync(request);
                if (response.ResponseStatus == ResponseStatus.Completed)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
                        return false;

                    return true;
                }
                else
                    return false;
            }
        }


    }
}
