﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;
namespace JSONService.Model
{
    [DataContract]
    public class Estudiante
    {
        [DataMember(Name = "id")]
        public String Id { get; set; }

        [DataMember(Name = "nombre")]
        public String Nombre { get; set; }

        [DataMember(Name = "apellidopaterno")]
        public String ApellidoPaterno { get; set; }

        [DataMember(Name = "apellidomaterno")]
        public String ApellidoMaterno { get; set; }

        [DataMember(Name = "edad")]
        public int Edad { get; set; }

    }
}