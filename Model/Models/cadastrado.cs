
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Model.Models
{
    public class cadastrado
    {
        private int id;
        private string nome;
        private decimal valor_unitario { get; set; }
        private int quantidade_de_protudo { get; set; }




        public cadastrado()
        {
        }
        [Key]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [Display(Name = "Nome")]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }

}