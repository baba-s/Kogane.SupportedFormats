using System.IO;

namespace MyProject
{
    /// <summary>
    /// サポートする形式を管理するクラス
    /// </summary>
    public static class SupportedFormats
    {
        //================================================================================
        // 関数(static)
        //================================================================================
        /// <summary>
        /// AudioClip の場合 true を返します
        /// </summary>
        public static bool IsAudioClipPath( string path )
        {
            var extension = Path.GetExtension( path );

            return IsAudioClipExtension( extension );
        }

        /// <summary>
        /// AudioClip の場合 true を返します
        /// </summary>
        public static bool IsAudioClipExtension( string extension )
        {
            return
                extension is
                    ".mp3" or
                    ".ogg" or
                    ".wav" or
                    ".aiff" or
                    ".aif" or
                    ".mod" or
                    ".it" or
                    ".s3m" or
                    ".xm"
                ;
        }
    }
}