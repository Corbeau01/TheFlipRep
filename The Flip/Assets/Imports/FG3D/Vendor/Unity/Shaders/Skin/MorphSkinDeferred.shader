Shader "FG3D/Skin Deferred" {
	Properties{
		_Color("Color", Color) = (1,1,1,1)
		_MainTex("Albedo (RGB)", 2D) = "white" {}
		_NormalTex("Normal", 2D) = "bump" {}

		_Glossiness("Smoothness", Range(0,1)) = 0.5
		//_Metallic("Metallic", Range(0,1)) = 0.0

		_AlphaTex("Alpha Texture", 2D) = "white" {}
		_AlphaCutoff("Alpha Cutoff", Range(0.0, 1.0)) = 0.5

		_SpecColorA("Specular", Color) = (0.2,0.2,0.2,1)
		_SpecGlossMap("Specular", 2D) = "white" {}
		_OcclusionStrength("Strength", Range(0.0, 1.0)) = 1
		_OcclusionMap("Occlusion", 2D) = "white" {}
	}

	SubShader{
		Tags{
			"Queue" = "Transparent"
		}
		LOD 200

		Cull Back
		ZWrite On
		Blend SrcAlpha OneMinusSrcAlpha

		CGPROGRAM
		#pragma target 3.0
		#pragma surface surf StandardSpecular nolightmap noforwardadd addshadow

		sampler2D _MainTex;

		sampler2D _NormalTex;

		sampler2D _AlphaTex;
		float _AlphaCutoff;

		sampler2D _SpecGlossMap;
		sampler2D _OcclusionMap;
		float4 _SpecColorA;
		float _OcclusionStrength;

		struct Input {
			float2 uv_MainTex;
			float2 uv_NormalTex;
			float2 uv_OcclusionTex;
			float2 uv_SpecGlossTex;
		};

		float _Glossiness;
		//half _Metallic;
		float4 _Color;


		void surf(Input IN, inout SurfaceOutputStandardSpecular o) {
			// Albedo comes from a texture tinted by color
			float4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			o.Albedo = c.rgba;
			o.Alpha = tex2D(_AlphaTex, IN.uv_MainTex.xy).r;//use our custom alpha map

			clip(o.Alpha - _AlphaCutoff);

			o.Alpha = c.a;
			o.Normal = UnpackNormal(tex2D(_NormalTex, IN.uv_NormalTex));
			o.Occlusion = tex2D(_OcclusionMap, IN.uv_OcclusionTex) * (_OcclusionStrength);

			//SurfaceOutputStandard
			//o.Metallic = _Metallic;

			//SurfaceOutputStandardSpecular
			o.Specular = tex2D(_SpecGlossMap, IN.uv_SpecGlossTex) * _SpecColorA;
			o.Smoothness = _Glossiness;
		}
		ENDCG
	}
	FallBack "Diffuse"
}
