using System;
using System.Collections.Generic;
using System.Text;

namespace LoginApp.Helpers
{
    public class LocalizedStrings
    {
        /// <param name="key"></param>
        /// <returns></returns>
        public string this[string key] => ResourceFile.ResourceManager.GetString(key);

        /// <summary>
        /// Gets the string from the resources with the specified resource id.
        /// </summary>
        /// <param name="resourceId">
        /// The resource id of the string to get
        /// </param>
        /// <returns>
        /// The string with the specified resource id, or null if it can't be found
        /// </returns>
        public static string GetString(string resourceId)
        {
            string resourceString = null;
            var loader = ResourceFile.ResourceManager;
            if (null != loader && !string.IsNullOrEmpty(resourceId))
            {
                resourceString = loader.GetString(resourceId);

                if (string.IsNullOrEmpty(resourceString))
                {
                    resourceString = null; // If the resource isn't found, return null.
                }
            }
            return resourceString;
        }
    }
}
