# Kogane Supported Formats

指定されたパスや拡張子が Unity がサポートする形式かどうか確認できるクラス

## 使用例

```cs
using Kogane;
using UnityEditor;
using UnityEngine;

public static class Example
{
    [MenuItem( "Tools/Hoge" )]
    public static void Hoge()
    {
        // AudioClip のパスなら true
        Debug.Log( SupportedFormats.IsAudioClipPath( "Assets/a.ogg" ) );

        // AudioClip の拡張子なら true
        Debug.Log( SupportedFormats.IsAudioClipExtension( ".ogg" ) );
    }
}
```