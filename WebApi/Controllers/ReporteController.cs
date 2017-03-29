using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using WebAppiEs.Models;
using System.Web;
using WebApi.Models.AB;

namespace WebApiEDD.Controllers
{
    public class ReporteController : ApiController
    {
        Arbol2 arbol = new Arbol2();



        //GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }



        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value_";
        }



        //POST api/<controller>


        [AcceptVerbs("POST", "PUT")]
        [HttpPost]
        [Route("api/ReporteController/prove")]
        [ActionName("prove")]
        public String Post([FromBody]requerimiento value)
        {
            //String dat = Convert.ToString(Request);
            System.Diagnostics.Debug.WriteLine(value.dato);
            System.Diagnostics.Debug.WriteLine(value.dato2);
            return "hquiioionaz";
        }




        [HttpPost]
        [Route("api/ReporteController/insertar")]
        [ActionName("insertar")]
        public String insertar([FromBody]requerimiento value)
        {
            String activo,usuario, empresa,depto,fecha,hora;
            empresa = value.empresa;
            activo = value.activo;
            usuario = value.usuario;
            depto = value.depto;
            fecha = value.fecha;
            hora = value.hora;
            System.Diagnostics.Debug.WriteLine("el activo es"+value.activo+ " ,  "+value.usuario);

            arbol.InsertarNuevo(arbol.nuevo(activo, usuario, empresa, depto, fecha, hora));

            //String dat = Convert.ToString(Request);
            //System.Diagnostics.Debug.WriteLine(value.activo);
            return "Se inserto activo";
        }





        [HttpPost]
        [Route("api/ReporteController/probando")]
        [ActionName("probando")]
        public String probando([FromBody]requerimiento value)
        {
            //String dat = Convert.ToString(Request);
            System.Diagnostics.Debug.WriteLine(value.dato);
            String dato2 = value.dato;
            System.Diagnostics.Debug.WriteLine(dato2);
            Console.WriteLine(value.dato);
            //System.Diagnostics.Debug.WriteLine(value.dato2);
            return "hola mundo";
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}