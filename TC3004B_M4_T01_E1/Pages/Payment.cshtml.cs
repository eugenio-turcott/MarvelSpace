using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using System;
using System.Text.RegularExpressions;

namespace TC3004B_M4_T01_E1.Pages
{
    public class PaymentModel : PageModel
    {
        [BindProperty]
        public string Nombre { get; set; }
        [BindProperty]
        public string Apellidos { get; set; }
        [BindProperty]
        public string Telefono { get; set; }
        [BindProperty]
        public string CP { get; set; }
        [BindProperty]
        public string Calle { get; set; }
        [BindProperty]
        public string NumExt { get; set; }
        [BindProperty]
        public string Colonia { get; set; }
        [BindProperty]
        public string Tarjeta { get; set; }
        [BindProperty]
        public string NombreTarjeta { get; set; }
        [BindProperty]
        public string MesVenc { get; set; }
        [BindProperty]
        public string AnioVenc { get; set; }
        [BindProperty]
        public string CVV { get; set; }
        [BindProperty]
        public string OrderNextPage { get; set; }
        [BindProperty]
        public string TotalNextPage { get; set; }

        public void OnGet(string Total, string Order)
        {
            ViewData["PaymentTotal"] = Total;
            ViewData["PaymentOrder"] = Order;

            Nombre = "";
            Apellidos = "";
            CP = "";
            Calle = "";
            NumExt = "";
            Colonia = "";
            Tarjeta = "";
            OrderNextPage = "";
            TotalNextPage = "";
        }

        public void OnPost()
        {
            string result = "";
            string result2 = "";
            string result3 = "";
            string result4 = "";
            string result5 = "";

            Random rnd = new Random();
            int pedidoRandom = rnd.Next(1, 101);

            string order = OrderNextPage;
            string nombreCompleto = Nombre + " " + Apellidos;
            string direccion = Calle + " " + NumExt + ", " + Colonia + ", C.P. " + CP;
            string pagoOculto = OcultarDigitos(Tarjeta);
            string pagoTotal = TotalNextPage;

            result = order;
            result2 = nombreCompleto;
            result3 = direccion;
            result4 = pagoOculto;
            result5 = pagoTotal;

            Response.Redirect("Successful?Pedido=" + pedidoRandom + "&Order=" + result + "&Nombre=" + result2 + "&Direccion=" + result3 + "&Pago=" + result4 + "&Total=" + result5);
        }

        public string OcultarDigitos(string numeroTarjeta)
        {
            // Obtener los últimos cuatro dígitos
            string ultimosCuatroDigitos = numeroTarjeta.Substring(numeroTarjeta.Length - 4);

            // Reemplazar solo los dígitos numéricos con asteriscos
            string oculto = Regex.Replace(numeroTarjeta, @"\d", "*");

            // Mantener los guiones en su lugar
            oculto = oculto.Substring(0, oculto.Length - 4) + ultimosCuatroDigitos;

            return oculto;
        }
    }
}
