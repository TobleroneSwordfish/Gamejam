Shader "MK/Glow/Selective/Diffuse - Worldspace - glow"
{
	Properties
	{
		_Color("Main Color", Color) = (1,1,1,1)
		_MainTex("Base (RGB)", 2D) = "white" {}
		_Scale("Texture Scale", Float) = 1.0
		_MKGlowColor("Glow Color", Color) = (1,1,1,1)
		_MKGlowPower("Glow Power", Range(0.0,2.5)) = 1.0
		_MKGlowTex("Glow Texture", 2D) = "black" {}
		_MKGlowTexColor("Glow Texture Color", Color) = (1,1,1,1)
		_MKGlowTexStrength("Glow Texture Strength ", Range(0.0,10.0)) = 1.0
	}

		SubShader
	{
		Tags{ "RenderType" = "Opaque" }
		LOD 200

		CGPROGRAM
#pragma surface surf Lambert
		sampler2D _MKGlowTex;
		half _MKGlowTexStrength;
		fixed4 _MKGlowTexColor;
		sampler2D _MainTex;
	fixed4 _Color;
	float _Scale;

	struct Input
	{
		float3 worldNormal;
		float3 worldPos;
		float2 uv_MainTex;
	};

	void surf(Input IN, inout SurfaceOutput o)
	{
		float2 UV;
		fixed4 c;

		if (abs(IN.worldNormal.x)>0.5)
		{
			UV = IN.worldPos.yz; // side
			c = tex2D(_MainTex, UV* _Scale); // use WALLSIDE texture
		}
		else if (abs(IN.worldNormal.z)>0.5)
		{
			UV = IN.worldPos.xy; // front
			c = tex2D(_MainTex, UV* _Scale); // use WALL texture
		}
		else
		{
			UV = IN.worldPos.xz; // top
			c = tex2D(_MainTex, UV* _Scale); // use FLR texture
		}

		o.Albedo = c.rgb * _Color;
		fixed4 d = tex2D(_MKGlowTex, IN.uv_MainTex) * _MKGlowTexColor;
		c += (d * _MKGlowTexStrength);
	}
	ENDCG
	}

		Fallback "VertexLit"
}