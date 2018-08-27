using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.Models
{
    /// <summary>
    /// Classe modelo para o banco de dados de usuários
    /// </summary>
    public class UserModel : EntityBase
    {
        public virtual string Name { get; set; }
        public virtual string Password { get; set; }
        /// <summary>
        /// Matricula da ArcelorMittal
        /// </summary>
        public virtual string ArcelorRegistration { get; set; }
        public virtual string Email { get; set; }
        public virtual string Tellphone { get; set; }
        public virtual string Cellphone { get; set; }
    }
}