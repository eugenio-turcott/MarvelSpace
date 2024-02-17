using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using System;
using System.Text.RegularExpressions;

namespace TC3004B_M4_T01_E1.Pages
{
    public class SuccessfulModel : PageModel
    {
        public void OnGet(string Pedido, string Order, string Nombre, string Direccion, string Pago, string Total)
        {
            ViewData["PaymentSuccessPedido"] = Pedido;
            ViewData["PaymentSuccessOrder"] = Order;
            ViewData["PaymentSuccessNombre"] = Nombre;
            ViewData["PaymentSuccessDireccion"] = Direccion;
            ViewData["PaymentSuccessPago"] = Pago;
            ViewData["PaymentSuccessTotal"] = Total;
        }
    }
}
