﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlbumOnline.Models.Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModelAlbumOnlineContainer : DbContext
    {
        public ModelAlbumOnlineContainer()
            : base("name=ModelAlbumOnlineContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tipo> Tipos { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Comentario> Comentarios { get; set; }
    }
}
