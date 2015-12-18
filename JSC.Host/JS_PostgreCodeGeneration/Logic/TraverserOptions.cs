/*
* Created by: Yevgeniy A. Matveichev
* Created: 18/12/2015
* Copyright © JSC Portal 2015
*/

namespace JS_PostgreCodeGeneration.Logic
{
    using System.Dynamic;

    internal class TraverserOptionsBuilder
    {
        public static TraverserOptions DefaultOptions 
        {
            get
            {
                return new TraverserOptions { DatabaseSchema = "default" };
            }
        }
    }

    /// <summary>
    /// This struct will handle the options for traverser;
    /// </summary>
    public struct TraverserOptions
    {
        public string DatabaseSchema { get; set; }

        public string TraverserQuery { get; set; }
    }
}
