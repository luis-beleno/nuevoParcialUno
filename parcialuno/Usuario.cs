using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial
{
    public class Usuario
    {
        public String codigo;
        public String usuario;

        public String Codigos { get { return codigo; } set { codigo = value; } }
        public String Usuarios { get { return usuario; } set { usuario = value; } }

        public Usuario(String _codigo, String _usuario)
        {
            this.codigo = _codigo;
            this.usuario = _usuario;
        }
    }

    public class Blogs : Usuario
    {
        public String blogId;
        public String blogName;
        public String blogDate;

        public String BlogId { get { return blogId; } set { blogId = value; } }
        public String BlogName { get { return blogName; } set { blogName = value; } }
        public String BlogDate { get { return blogDate; } set { blogDate = value; } }

        public Blogs(String _blogId, String _blogName, String _codigo = null, String _usuario = null, String _blogDate = null)
            : base(_codigo, _usuario)
        {
            this.blogId = _blogId;
            this.blogName = _blogName;
            this.blogDate = _blogDate;
        }

    }
}
