﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDevPnP.Core.Framework.Provisioning.Model
{
    /// <summary>
    /// Defines an Add-in to provision
    /// </summary>
    public class Addin : IEquatable<Addin>
    {
        #region Public Members

        /// <summary>
        /// Defines the .app file of the SharePoint Add-in to provision
        /// </summary>
        public String PackagePath { get; set; }

        /// <summary>
        /// Defines the Source of the SharePoint Add-in to provision
        /// </summary>
        /// <remarks>
        /// Possible values are: CorporateCatalog, DeveloperSite, InvalidSource, Marketplace, ObjectModel, RemoteObjectModel
        /// </remarks>
        public String Source { get; set; }

        #endregion

        #region Comparison code

        public override int GetHashCode()
        {
            return (String.Format("{0}|{1}|",
                this.PackagePath,
                this.Source
                ).GetHashCode());
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Addin))
            {
                return (false);
            }
            return (Equals((Addin)obj));
        }

        public bool Equals(Addin other)
        {
            return (this.PackagePath == other.PackagePath &&
                this.Source == other.Source
                );
        }

        #endregion
    }
}
