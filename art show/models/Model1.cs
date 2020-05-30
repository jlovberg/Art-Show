namespace art_show_app.models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<art_show> art_show { get; set; }
        public virtual DbSet<artist> artists { get; set; }
        public virtual DbSet<artwork> artworks { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<art_show>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<art_show>()
                .Property(e => e.contact_phone)
                .IsUnicode(false);

            modelBuilder.Entity<art_show>()
                .Property(e => e.contact_name)
                .IsUnicode(false);

            modelBuilder.Entity<art_show>()
                .Property(e => e.artist)
                .IsUnicode(false);

            modelBuilder.Entity<art_show>()
                .HasMany(e => e.artworks)
                .WithMany(e => e.art_show)
                .Map(m => m.ToTable("shown", "art").MapLeftKey(new[] { "date_and_time", "location" }).MapRightKey("artwork"));

            modelBuilder.Entity<artist>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<artist>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<artist>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<artist>()
                .Property(e => e.birth_place)
                .IsUnicode(false);

            modelBuilder.Entity<artist>()
                .Property(e => e.style_of_art)
                .IsUnicode(false);

            modelBuilder.Entity<artist>()
                .HasMany(e => e.artworks)
                .WithOptional(e => e.artist1)
                .HasForeignKey(e => e.artist);

            modelBuilder.Entity<artwork>()
                .Property(e => e.unique_title)
                .IsUnicode(false);

            modelBuilder.Entity<artwork>()
                .Property(e => e.artist)
                .IsUnicode(false);

            modelBuilder.Entity<artwork>()
                .Property(e => e.type_of_art)
                .IsUnicode(false);

            modelBuilder.Entity<artwork>()
                .Property(e => e.price)
                .HasPrecision(10, 0);

            modelBuilder.Entity<artwork>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<artwork>()
                .Property(e => e.customerphone)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.art_preferences)
                .IsUnicode(false);
        }
    }
}
