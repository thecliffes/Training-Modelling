using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Dreamteck.Splines.Examples
{
    class Program : MonoBehaviour
    {
        void Start()
        {
            string uri= "http://localhost:8080/trains/train_2/current-speed-and-direction";
            restClient rClient = new restClient();
            rClient.endPoint = uri;

            string strResponse = string.Empty;

            strResponse = rClient.makeRequest();

            Debug.Log(strResponse);

            
        }

        //look at json.net deserialization for when i need to deserialze the json


    }
}
