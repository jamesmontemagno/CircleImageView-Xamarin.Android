
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Refractored.Controls
{
    /// <summary>
    /// Circle image view.
    /// </summary>
    public class CircleImageView : _BaseCircleImageView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Refractored.Controls.CircleImageView"/> class.
        /// </summary>
        /// <param name="context">Context.</param>
        public CircleImageView(Context context)
            : base(context)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Refractored.Controls.CircleImageView"/> class.
        /// </summary>
        /// <param name="context">Context.</param>
        /// <param name="attrs">Attrs.</param>
        public CircleImageView(Context context, IAttributeSet attrs)
            : base(context, attrs)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Refractored.Controls.CircleImageView"/> class.
        /// </summary>
        /// <param name="context">Context.</param>
        /// <param name="attrs">Attrs.</param>
        /// <param name="defStyle">Def style.</param>
        public CircleImageView(Context context, IAttributeSet attrs, int defStyle)
            : base(context, attrs, defStyle)
        {
            Initialize();
        }

        /// <summary>
        /// Initialize this instance.
        /// </summary>
        void Initialize()
        {
        }
    }
}

