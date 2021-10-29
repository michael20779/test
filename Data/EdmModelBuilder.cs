//-----------------------------------------------------------------------------
// <copyright file="EdmModelBuilder.cs" company=".NET Foundation">
//      Copyright (c) .NET Foundation and Contributors. All rights reserved.
//      See License.txt in the project root for license information.
// </copyright>
//------------------------------------------------------------------------------

using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using corewebapioracle.Data;
using System.Web.Http;
using Microsoft.AspNet.OData;

namespace ODataRoutingSample.Models
{
    public static class EdmModelBuilder
    {   
        public static IEdmModel GetEdmModel()
        {   
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<ContactEm>("ContactEms").EntityType.HasKey(p => new { p.ContactId });
                                    
            return builder.GetEdmModel();

        }
    }
}

  

          