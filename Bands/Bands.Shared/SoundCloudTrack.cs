using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using Windows.Data.Json;

namespace SoundCloudeStreaming
{

    class SoundCloudTrack
    {
        public string title { get; set; }
        private string _stream_url;

        public string stream_url
        {
            get { return _stream_url; }
            set { _stream_url = value; }

        }

        public SoundCloudTrack(JsonObject json)
        {
            var Properties = this.GetType().GetRuntimeProperties();

            foreach (PropertyInfo Property in Properties)
            {
                if (json.GetObject().ContainsKey(Property.Name))
                    Property.SetValue(this, Convert.ChangeType(json.GetObject().GetNamedString(Property.Name).Replace("\\n", Environment.NewLine), Property.PropertyType));
                else
                    throw new ArgumentException(String.Format("Json Object Doesn't Contain Key Named {0}.", Property.Name));
            }
        }
    }
}
