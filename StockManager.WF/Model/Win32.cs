using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace StockManager.WF.Model
{
    class Win32
    {
        /// <summary>
        /// animation
        /// </summary>
        /// <param name="whnd">控件句柄</param>
        /// <param name="dwtime">temps</param>
        /// <param name="dwflag">composant de nom de animation</param>
        /// <returns>bool，animation chargée avec succès ou pas</returns>
        [DllImport("user32.dll")]
        public static extern bool AnimateWindow(IntPtr whnd, int dwtime, int dwflag);

        /// <summary>
        /// de gauche à droit
        /// </summary>
        public const int AW_HOR_POSITIVE = 0x00000001;
        /// <summary>
        /// de droit à gauche
        /// </summary>
        public const int AW_HOR_NEGATIVE = 0x00000002;
        /// <summary>
        /// de haut en bas
        /// </summary>
        public const int AW_VER_POSITIVE = 0x00000004;
        /// <summary>
        /// de bas en haut
        /// </summary>
        public const int AW_VER_NEGATIVE = 0x00000008;
        /// <summary>
        /// 若使用了AW_HIDE标志，则使窗口向内重叠，即收缩窗口；否则使窗口向外扩展，即展开窗口
        /// </summary>
        public const int AW_CENTER = 0x00000010;
        /// <summary>
        /// cacher la fenêtre, par défaut, afficher la fenêtre
        /// </summary>
        public const int AW_HIDE = 0x00010000;
        /// <summary>
        /// activer la fenêtre, 在使用了AW_HIDE标志后不能使用这个标志
        /// </summary>
        public const int AW_ACTIVATE = 0x00020000;
        /// <summary>
        /// 使用滑动类型。缺省则为滚动动画类型。当使用AW_CENTER标志时，这个标志就被忽略
        /// </summary>
        public const int AW_SLIDE = 0x00040000;
        /// <summary>
        /// opacity de haut vers bas
        /// </summary>
        public const int AW_BLEND = 0x00080000;
    }
}
