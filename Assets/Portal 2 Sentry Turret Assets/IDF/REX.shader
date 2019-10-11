// Made with Amplify Shader Editor
// Available at the Unity Asset Store - http://u3d.as/y3X 
Shader "Some gay shader for REX"
{
	Properties
	{
		[Normal]_Normal("Normal", 2D) = "bump" {}
		_Exponent("Exponent", 2D) = "white" {}
		_Diffuse("Diffuse", 2D) = "white" {}
		_Spec("Spec", Range( 0 , 5)) = 1
		_Smoothness("Smoothness", Range( 0 , 20)) = 1
		[HideInInspector] _texcoord( "", 2D ) = "white" {}
		[HideInInspector] __dirty( "", Int ) = 1
	}

	SubShader
	{
		Tags{ "RenderType" = "Opaque"  "Queue" = "Geometry+0" }
		Cull Back
		CGPROGRAM
		#pragma target 3.0
		#pragma surface surf StandardSpecular keepalpha addshadow fullforwardshadows 
		struct Input
		{
			float2 uv_texcoord;
		};

		uniform sampler2D _Normal;
		uniform float4 _Normal_ST;
		uniform sampler2D _Diffuse;
		uniform float4 _Diffuse_ST;
		uniform float _Spec;
		uniform sampler2D _Exponent;
		uniform float4 _Exponent_ST;
		uniform float _Smoothness;

		void surf( Input i , inout SurfaceOutputStandardSpecular o )
		{
			float2 uv_Normal = i.uv_texcoord * _Normal_ST.xy + _Normal_ST.zw;
			float3 tex2DNode3 = UnpackNormal( tex2D( _Normal, uv_Normal ) );
			float4 appendResult8 = (float4(tex2DNode3.r , -tex2DNode3.g , tex2DNode3.b , 0.0));
			o.Normal = appendResult8.xyz;
			float2 uv_Diffuse = i.uv_texcoord * _Diffuse_ST.xy + _Diffuse_ST.zw;
			o.Albedo = tex2D( _Diffuse, uv_Diffuse ).rgb;
			float2 uv_Exponent = i.uv_texcoord * _Exponent_ST.xy + _Exponent_ST.zw;
			float4 tex2DNode2 = tex2D( _Exponent, uv_Exponent );
			float clampResult13 = clamp( ( _Spec * tex2DNode2.g ) , 0.0 , 1.0 );
			float3 temp_cast_2 = (clampResult13).xxx;
			o.Specular = temp_cast_2;
			float clampResult12 = clamp( ( _Smoothness * tex2DNode2.r ) , 0.0 , 1.0 );
			o.Smoothness = clampResult12;
			o.Alpha = 1;
		}

		ENDCG
	}
	Fallback "Diffuse"
	CustomEditor "ASEMaterialInspector"
}
/*ASEBEGIN
Version=15900
205;92;1084;606;672.4929;379.2701;1.291222;True;False
Node;AmplifyShaderEditor.RangedFloatNode;15;0,-240;Float;False;Property;_Spec;Spec;3;0;Create;True;0;0;False;0;1;5;0;5;0;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;11;1.3,32;Float;False;Property;_Smoothness;Smoothness;4;0;Create;True;0;0;False;0;1;1;0;20;0;1;FLOAT;0
Node;AmplifyShaderEditor.SamplerNode;2;-656,192;Float;True;Property;_Exponent;Exponent;1;0;Create;True;0;0;False;0;None;9e47c5a097f7975418bb3710a1bfebe1;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SamplerNode;3;-1238.961,374.2912;Float;True;Property;_Normal;Normal;0;1;[Normal];Create;True;0;0;False;0;None;4529bfc015fbd75469e33198a4d642ea;True;0;True;bump;Auto;True;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;FLOAT3;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;14;64,-176;Float;True;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;10;80,96;Float;True;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.NegateNode;9;-897.5,428.5;Float;True;1;0;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.ClampOpNode;13;288,-176;Float;True;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.ClampOpNode;12;291.6646,104.3278;Float;True;3;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;1;FLOAT;0
Node;AmplifyShaderEditor.SamplerNode;1;-656,0;Float;True;Property;_Diffuse;Diffuse;2;0;Create;True;0;0;False;0;None;7df7148972551404e86b15004c0bae99;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.DynamicAppendNode;8;-691.5,400.5;Float;True;FLOAT4;4;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;0;False;3;FLOAT;0;False;1;FLOAT4;0
Node;AmplifyShaderEditor.StandardSurfaceOutputNode;0;560,-16;Float;False;True;2;Float;ASEMaterialInspector;0;0;StandardSpecular;Some gay shader for REX;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;Back;0;False;-1;0;False;-1;False;0;False;-1;0;False;-1;False;0;Opaque;0.5;True;True;0;False;Opaque;;Geometry;All;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;0;False;-1;False;0;False;-1;255;False;-1;255;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;False;2;15;10;25;False;0.5;True;0;0;False;-1;0;False;-1;0;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;0;0,0,0,0;VertexOffset;True;False;Cylindrical;False;Relative;0;;-1;-1;-1;-1;0;False;0;0;False;-1;-1;0;False;-1;0;0;0;16;0;FLOAT3;0,0,0;False;1;FLOAT3;0,0,0;False;2;FLOAT3;0,0,0;False;3;FLOAT3;0,0,0;False;4;FLOAT;0;False;5;FLOAT;0;False;6;FLOAT3;0,0,0;False;7;FLOAT3;0,0,0;False;8;FLOAT;0;False;9;FLOAT;0;False;10;FLOAT;0;False;13;FLOAT3;0,0,0;False;11;FLOAT3;0,0,0;False;12;FLOAT3;0,0,0;False;14;FLOAT4;0,0,0,0;False;15;FLOAT3;0,0,0;False;0
WireConnection;14;0;15;0
WireConnection;14;1;2;2
WireConnection;10;0;11;0
WireConnection;10;1;2;1
WireConnection;9;0;3;2
WireConnection;13;0;14;0
WireConnection;12;0;10;0
WireConnection;8;0;3;1
WireConnection;8;1;9;0
WireConnection;8;2;3;3
WireConnection;0;0;1;0
WireConnection;0;1;8;0
WireConnection;0;3;13;0
WireConnection;0;4;12;0
ASEEND*/
//CHKSM=510EE7937D9A929C9B6ACEB7043FBA02203C307F