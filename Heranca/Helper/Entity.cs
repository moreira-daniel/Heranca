using System;

namespace Heranca.Helper
{
    public abstract class Entity 
    {

        public bool Ativo { get; private set; }

        public int Id { get; set; }

        public void SetAtivo(bool ativo)
        {
            Ativo = ativo;
        }
    }
}