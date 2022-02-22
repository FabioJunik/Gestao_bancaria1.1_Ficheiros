using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novembro_15
{
    public partial class transacoes : Component
    {
        public transacoes()
        {
            InitializeComponent();
        }

        public transacoes(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
