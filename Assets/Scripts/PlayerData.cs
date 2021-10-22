﻿using hololensMultiplayer.Models;

using Lidgren.Network;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace hololensMultiplayer
{
    public class PlayerData
    {
        public int ID;
        public NetConnection connection;
        public string Name = "Player";

        public Vector3 Position = new Vector3();
        public Quaternion Rotation = new Quaternion();
        public Vector3 QrOffset = new Vector3();

        public bool RHActive = false;
        public FingersState RHFingers;
        public Vector3 RHPosition = new Vector3();
        public Quaternion RHRotation = new Quaternion();

        public bool LHActive = false;
        public FingersState LHFingers;
        public Vector3 LHPosition = new Vector3();
        public Quaternion LHRotation = new Quaternion();

        public GameObject playerObject;

        public PlayerData()
        {

        }
    }
}