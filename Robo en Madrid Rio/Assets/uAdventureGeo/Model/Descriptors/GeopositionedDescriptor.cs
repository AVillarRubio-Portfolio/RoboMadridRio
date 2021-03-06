using System;
using System.Collections.Generic;
using UnityEngine;

namespace uAdventure.Geo
{
    public class GeopositionedDescriptor : ITransformManagerDescriptor
    {

        public GeopositionedDescriptor()
        {
            ParameterDescription = new Dictionary<string, Geo.ParameterDescription>
            {
                { "Position", new ParameterDescription(typeof(Vector2d), Vector2d.zero) },
                { "Rotation", new ParameterDescription(typeof(float), 0f) },
                { "InteractionRange", new ParameterDescription(typeof(float), 25f) }, // 25 metros
                { "RevealOnlyOnRange", new ParameterDescription(typeof(bool), true) },
                { "RevealParticleTexture", new ParameterDescription(typeof(string), "leaf_particle.png") }
            };
        }

        public string Name { get { return "WorldPositioned"; } }
        public Dictionary<string, ParameterDescription> ParameterDescription { get; private set; }
        public Type Type { get { return typeof(GeolocationTransformManager); } }
    }
}
