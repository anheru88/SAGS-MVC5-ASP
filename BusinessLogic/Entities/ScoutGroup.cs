﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLogic
{
    [Table("Scout Group")]
    public class ScoutGroup
    {
        #region Atributes

        private static ScoutGroup scoutGroupInstance;

        #endregion

        #region Properties

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Telephones { get; set; }

        [Required]
        public string Sponsor { get; set; }

        #endregion

        #region Methods

        public static ScoutGroup getInstance()
        {
            if (scoutGroupInstance == null)
                scoutGroupInstance = new ScoutGroup();
            return scoutGroupInstance;
        }

        #endregion

        #region Overwritten methods

        public override string ToString()
        {
            return "\nScout Group: \nId: " + scoutGroupInstance.Id +
                "\nName: " + scoutGroupInstance.Name +
                "\nNumber: " + scoutGroupInstance.Number +
                "\nCity: " + scoutGroupInstance.City +
                "\nState: " + scoutGroupInstance.State +
                "\nCountry: " + scoutGroupInstance.Country +
                "\nAddress: " + scoutGroupInstance.Address +
                "\nTelephones: " + scoutGroupInstance.Telephones +
                "\nSponsor: " + scoutGroupInstance.Sponsor;
        }

        #endregion
    }
}
