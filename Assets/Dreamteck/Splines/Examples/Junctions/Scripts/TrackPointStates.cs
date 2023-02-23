using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Dreamteck.Splines.Examples

{
    class TrackPointStates : MonoBehaviour
    {
        void Start()
        {
            getState();
            
        }

        //look at json.net deserialization for when i need to deserialze the json

        public void getState(){
            string uri= "http://localhost:8080/track-circuits/point-states";
            restClient rClient = new restClient();
            rClient.endPoint = uri;

            string strResponse = string.Empty;

            strResponse = rClient.makeRequest();

            Debug.Log(strResponse);
        }

    }
}
