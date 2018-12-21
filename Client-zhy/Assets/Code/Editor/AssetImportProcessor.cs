using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//工作机和mac的unity版本不一致，导致serializedVersion不一致，总是红色，等到版本一致后，再放开该设置脚本

/*
public class AssetImportProcessor : AssetPostprocessor
{
	void OnPostprocessTexture(Texture2D texture)
	{
		if (assetPath.Contains("Res/UI"))
		{
            TextureImporter textureImporter = (TextureImporter)assetImporter;
            textureImporter.textureType = TextureImporterType.GUI;
            textureImporter.alphaSource = TextureImporterAlphaSource.FromInput;
            textureImporter.alphaIsTransparency = true;
            textureImporter.isReadable = false;
			textureImporter.mipmapEnabled = false;
            textureImporter.wrapMode = TextureWrapMode.Clamp;
            textureImporter.filterMode = FilterMode.Bilinear;
            textureImporter.maxTextureSize = 2048;
            var texSetting = textureImporter.GetDefaultPlatformTextureSettings();
            texSetting.resizeAlgorithm = TextureResizeAlgorithm.Mitchell;
            textureImporter.textureCompression = TextureImporterCompression.Compressed;
        }
	}
}
*/
