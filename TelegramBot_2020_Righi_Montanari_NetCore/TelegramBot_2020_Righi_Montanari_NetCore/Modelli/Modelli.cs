using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.SqlClient;

    
namespace TelegramBot
{
    public class Professore
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Flag_Feedback { get; set; }
        public bool Flag_Ban { get; set; }
        public bool Flag_Circolari { get; set; }
        public bool Flag_Condizioni { get; set; }
    }

    public class Studente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Nickname { get; set; }
        public string Classe { get; set; }
        public bool Flag_Feedback { get; set; }
        public bool Flag_Ban { get; set; }
        public bool Flag_Circolari { get; set; }


    }
}

