// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Face Attributes
    /// </summary>
    public partial class FaceAttributes
    {
        /// <summary>
        /// Initializes a new instance of the FaceAttributes class.
        /// </summary>
        public FaceAttributes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FaceAttributes class.
        /// </summary>
        /// <param name="age">Age in years</param>
        /// <param name="gender">Possible gender of the face. Possible values
        /// include: 'male', 'female'</param>
        /// <param name="smile">Smile intensity, a number between [0,1]
        /// </param>
        /// <param name="glasses">Glasses type if any of the face. Possible
        /// values include: 'noGlasses', 'readingGlasses', 'sunglasses',
        /// 'swimmingGoggles'</param>
        public FaceAttributes(double? age = default(double?), Gender? gender = default(Gender?), double? smile = default(double?), FacialHairProperties facialHair = default(FacialHairProperties), GlassesTypes? glasses = default(GlassesTypes?), HeadPoseProperties headPose = default(HeadPoseProperties), EmotionProperties emotion = default(EmotionProperties), HairProperties hair = default(HairProperties), MakeupProperties makeup = default(MakeupProperties), OcclusionProperties occlusion = default(OcclusionProperties), IList<AccessoryItem> accessories = default(IList<AccessoryItem>), BlurProperties blur = default(BlurProperties), ExposureProperties exposure = default(ExposureProperties), NoiseProperties noise = default(NoiseProperties))
        {
            Age = age;
            Gender = gender;
            Smile = smile;
            FacialHair = facialHair;
            Glasses = glasses;
            HeadPose = headPose;
            Emotion = emotion;
            Hair = hair;
            Makeup = makeup;
            Occlusion = occlusion;
            Accessories = accessories;
            Blur = blur;
            Exposure = exposure;
            Noise = noise;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets age in years
        /// </summary>
        [JsonProperty(PropertyName = "age")]
        public double? Age { get; set; }

        /// <summary>
        /// Gets or sets possible gender of the face. Possible values include:
        /// 'male', 'female'
        /// </summary>
        [JsonProperty(PropertyName = "gender")]
        public Gender? Gender { get; set; }

        /// <summary>
        /// Gets or sets smile intensity, a number between [0,1]
        /// </summary>
        [JsonProperty(PropertyName = "smile")]
        public double? Smile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "facialHair")]
        public FacialHairProperties FacialHair { get; set; }

        /// <summary>
        /// Gets or sets glasses type if any of the face. Possible values
        /// include: 'noGlasses', 'readingGlasses', 'sunglasses',
        /// 'swimmingGoggles'
        /// </summary>
        [JsonProperty(PropertyName = "glasses")]
        public GlassesTypes? Glasses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "headPose")]
        public HeadPoseProperties HeadPose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emotion")]
        public EmotionProperties Emotion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hair")]
        public HairProperties Hair { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "makeup")]
        public MakeupProperties Makeup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "occlusion")]
        public OcclusionProperties Occlusion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accessories")]
        public IList<AccessoryItem> Accessories { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "blur")]
        public BlurProperties Blur { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exposure")]
        public ExposureProperties Exposure { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "noise")]
        public NoiseProperties Noise { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Smile > 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Smile", 1);
            }
            if (Smile < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Smile", 0);
            }
            if (FacialHair != null)
            {
                FacialHair.Validate();
            }
            if (Emotion != null)
            {
                Emotion.Validate();
            }
            if (Hair != null)
            {
                Hair.Validate();
            }
            if (Blur != null)
            {
                Blur.Validate();
            }
            if (Exposure != null)
            {
                Exposure.Validate();
            }
            if (Noise != null)
            {
                Noise.Validate();
            }
        }
    }
}