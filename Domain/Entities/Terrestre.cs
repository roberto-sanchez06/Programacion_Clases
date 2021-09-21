﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Clase1_Programacion
{
    public class Terrestre : MediosDeTransporte
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        //el enum se puede crear aqui
        /*public enum Transmision{
            Mecanica, Automatica
        }*/
        public Transmision Transmision { get; set; }
        public Terrestre(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
    }
}
