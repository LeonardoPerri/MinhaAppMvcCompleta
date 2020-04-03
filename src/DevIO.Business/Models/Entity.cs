using System;

namespace DevIO.Business.Models
{
    //Classe abstrata, só pode ser herdada
    public abstract class Entity
    {
        //Construtor protected, pois, a classe só pode ser herdada
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
