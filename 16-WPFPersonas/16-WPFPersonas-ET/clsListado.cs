﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace _16_WPFPersonas_ET.Models
{
    public class clsListado
    {
        private Random r = new Random();

        public ObservableCollection<clsPersona> lista { get; set; }


        public clsListado()
        {
            lista = new ObservableCollection<clsPersona>();
            lista.Add(new clsPersona("Alberto", "Navarro", 1, new DateTime(1995,12,6), "C/ Mi calle, nº3, ", "666 555 444"));
            lista.Add(new clsPersona("Abradolf", "Lincler", 2, new DateTime(1945, 2, 15), "New Auschwitz", "666 666 123"));
            lista.Add(new clsPersona("Donald", "Trump", 3, new DateTime(1952, 7, 13), "New Jerksey", "123 456 789"));
           
        }

        public clsListado(int num)
        {
            lista = new ObservableCollection<clsPersona>();
            lista.Add(new clsPersona("Alberto", "Navarro", 1, new DateTime(1995, 12, 6), "C/ Mi calle, nº3, ", "666 555 444"));
            lista.Add(new clsPersona("Abradolf", "Lincler", 2, new DateTime(1945, 2, 15), "New Auschwitz", "666 666 123"));
            lista.Add(new clsPersona("Donald", "Trump", 3, new DateTime(1952, 7, 13), "New Jerksey", "123 456 789"));
            for (int i = 0; i < num; i++)
            {
                lista.Add(new clsPersona(generaNombre(),generaNombre()+" "+generaNombre(), i+1, new DateTime(r.Next(1900, 2000), r.Next(1, 12), r.Next(1, 29)), "C/"+generaNombre()+" "+ generaNombre()+", "+generaNombre(), generaTelf()));
            }
        }

        private string generaNombre()
        {
            string res = "";            

            //Crear arrays
            char[] vocales = "aeiou".ToCharArray();
            char[] consonantes = "bcdfhjlmnprstvz".ToCharArray();
            bool vocal = true;

            //Empiezo a meter letras
            res += Char.ToUpper((char)consonantes.GetValue(r.Next(0, consonantes.GetLength(0))));
            for (int i = 0; i < r.Next(5, 15); i++)
            {
                if (vocal)
                {
                    res += (char)vocales.GetValue(r.Next(0, 5));
                    vocal = false;
                }
                else
                {
                    res += (char)consonantes.GetValue(r.Next(0, consonantes.GetLength(0)));
                    vocal = true;
                }
            }

            if (r.Next(0, 10) == 1)
                res = "Fernando";

            return res;
        }

        private string generaTelf()
        {
            string res = "";
            char[] nums = "0123456789".ToCharArray();

            for (int i = 0; i < 11; i++)
            {
                if (i == 3 || i == 7)
                    res += " ";
                else
                    res += (char)nums.GetValue(r.Next(0, nums.GetLength(0)));
            }

            return res;
        }
        
    }
}