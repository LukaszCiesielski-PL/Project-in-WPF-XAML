﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Dziennik
{
    [Table("Uczen")]
    public partial class Uczen
    {
        public Uczen()
        {
            Ocenas = new HashSet<Ocena>();
        }

        [Key]
        [Column("ID_uczen")]
        public long IdUczen { get; set; }
        [Column(TypeName = "STRING")]
        public byte[] Imie { get; set; }
        [Column("Imie_drugie", TypeName = "STRING")]
        public byte[] ImieDrugie { get; set; }
        [Column(TypeName = "STRING")]
        public byte[] Nazwisko { get; set; }
        [Column("Data_urodzenia", TypeName = "DATE (10)")]
        public byte[] DataUrodzenia { get; set; }
        [Column(TypeName = "VARCHAR (11)")]
        public string Pesel { get; set; }
        [Column("Miasto_zam", TypeName = "STRING")]
        public byte[] MiastoZam { get; set; }
        [Column("Ulica_zam", TypeName = "STRING")]
        public byte[] UlicaZam { get; set; }
        [Column("Numer_ul", TypeName = "VARCHAR (8)")]
        public string NumerUl { get; set; }
        [Column("Numer_tel", TypeName = "STRING (12)")]
        public byte[] NumerTel { get; set; }
        [Column(TypeName = "STRING")]
        public byte[] Email { get; set; }
        [Column("ID_opiekun")]
        public long IdOpiekun { get; set; }
        [Column("ID_klasa")]
        public long? IdKlasa { get; set; }
        [Column(TypeName = "STRING (20)")]
        public string Login { get; set; }
        [Column(TypeName = "VARCHAR (20)")]
        public string Haslo { get; set; }

        [ForeignKey(nameof(IdKlasa))]
        [InverseProperty(nameof(Klasa.Uczens))]
        public virtual Klasa IdKlasaNavigation { get; set; }
        [ForeignKey(nameof(IdOpiekun))]
        [InverseProperty(nameof(Opiekun.Uczens))]
        public virtual Opiekun IdOpiekunNavigation { get; set; }
        [InverseProperty(nameof(Ocena.IdUczenNavigation))]
        public virtual ICollection<Ocena> Ocenas { get; set; }
    }
}
