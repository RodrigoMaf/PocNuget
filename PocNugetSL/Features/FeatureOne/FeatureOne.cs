using Microsoft.Extensions.Options;
using PocNugetSL.Configuration;
using PocNugetSL.Interfaces.FeatureOne;

namespace PocNugetSL.Features.FeatureOne
{
    /// <summary>Feature one classe implementation</summary>
    public class FeatureOne : IFeatureOne
    {
        #region Properties

        /// <summary>Feature one configuration data</summary>
        private ConfigurationFeatureOneData Configurations { get; }

        #endregion
        
        /// <summary>Initializes a new instance of the <see cref="FeatureOne"/> class.</summary>
        /// <param name="configOptions">Options - Feature one configuration data</param>
        internal FeatureOne(IOptions<ConfigurationFeatureOneData> configOptions)
        {
            Configurations = configOptions.Value;
        }
        
        /// <summary>Execute especific action from feature one</summary>
        public void Execute() 
        {
        
        }

        #region Private methods

        #endregion
    }
}
