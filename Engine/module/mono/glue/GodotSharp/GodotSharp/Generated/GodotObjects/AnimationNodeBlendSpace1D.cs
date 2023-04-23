using System;
using System.Diagnostics;

#pragma warning disable CS1591 // Disable warning: 'Missing XML comment for publicly visible type or member'
#pragma warning disable CS1573 // Disable warning: 'Parameter has no matching param tag in the XML comment'

namespace Godot
{
    /// <summary>
    /// <para>A resource to add to an <see cref="Godot.AnimationNodeBlendTree"/>.</para>
    /// <para>This is a virtual axis on which you can add any type of <see cref="Godot.AnimationNode"/> using <see cref="Godot.AnimationNodeBlendSpace1D.AddBlendPoint"/>.</para>
    /// <para>Outputs the linear blend of the two <see cref="Godot.AnimationNode"/>s closest to the node's current value.</para>
    /// <para>You can set the extents of the axis using the <see cref="Godot.AnimationNodeBlendSpace1D.MinSpace"/> and <see cref="Godot.AnimationNodeBlendSpace1D.MaxSpace"/>.</para>
    /// </summary>
    public partial class AnimationNodeBlendSpace1D : AnimationRootNode
    {
        public AnimationRootNode BlendPoint0__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(0, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint0__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(0);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(0, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint1__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(1, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint1__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(1);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(1, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint2__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(2, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint2__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(2);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(2, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint3__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(3, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint3__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(3);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(3, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint4__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(4, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint4__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(4);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(4, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint5__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(5, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint5__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(5);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(5, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint6__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(6);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(6, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint6__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(6);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(6, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint7__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(7);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(7, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint7__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(7);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(7, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint8__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(8);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(8, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint8__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(8);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(8, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint9__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(9);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(9, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint9__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(9);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(9, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint10__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(10);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(10, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint10__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(10);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(10, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint11__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(11);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(11, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint11__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(11);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(11, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint12__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(12);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(12, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint12__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(12);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(12, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint13__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(13);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(13, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint13__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(13);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(13, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint14__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(14);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(14, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint14__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(14);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(14, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint15__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(15);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(15, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint15__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(15);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(15, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint16__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(16);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(16, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint16__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(16);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(16, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint17__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(17);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(17, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint17__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(17);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(17, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint18__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(18);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(18, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint18__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(18);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(18, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint19__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(19);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(19, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint19__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(19);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(19, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint20__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(20);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(20, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint20__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(20);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(20, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint21__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(21);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(21, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint21__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(21);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(21, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint22__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(22);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(22, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint22__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(22);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(22, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint23__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(23);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(23, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint23__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(23);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(23, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint24__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(24);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(24, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint24__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(24);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(24, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint25__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(25);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(25, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint25__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(25);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(25, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint26__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(26);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(26, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint26__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(26);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(26, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint27__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(27);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(27, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint27__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(27);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(27, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint28__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(28);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(28, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint28__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(28);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(28, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint29__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(29);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(29, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint29__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(29);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(29, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint30__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(30);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(30, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint30__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(30);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(30, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint31__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(31);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(31, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint31__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(31);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(31, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint32__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(32);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(32, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint32__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(32);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(32, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint33__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(33);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(33, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint33__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(33);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(33, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint34__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(34);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(34, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint34__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(34);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(34, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint35__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(35);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(35, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint35__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(35);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(35, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint36__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(36);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(36, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint36__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(36);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(36, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint37__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(37);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(37, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint37__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(37);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(37, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint38__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(38);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(38, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint38__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(38);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(38, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint39__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(39);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(39, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint39__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(39);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(39, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint40__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(40);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(40, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint40__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(40);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(40, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint41__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(41);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(41, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint41__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(41);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(41, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint42__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(42);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(42, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint42__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(42);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(42, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint43__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(43);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(43, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint43__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(43);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(43, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint44__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(44);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(44, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint44__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(44);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(44, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint45__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(45);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(45, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint45__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(45);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(45, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint46__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(46);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(46, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint46__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(46);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(46, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint47__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(47);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(47, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint47__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(47);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(47, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint48__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(48);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(48, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint48__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(48);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(48, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint49__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(49);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(49, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint49__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(49);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(49, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint50__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(50);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(50, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint50__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(50);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(50, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint51__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(51);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(51, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint51__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(51);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(51, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint52__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(52);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(52, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint52__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(52);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(52, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint53__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(53);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(53, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint53__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(53);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(53, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint54__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(54);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(54, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint54__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(54);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(54, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint55__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(55);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(55, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint55__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(55);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(55, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint56__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(56);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(56, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint56__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(56);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(56, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint57__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(57);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(57, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint57__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(57);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(57, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint58__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(58);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(58, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint58__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(58);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(58, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint59__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(59);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(59, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint59__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(59);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(59, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint60__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(60);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(60, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint60__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(60);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(60, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint61__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(61);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(61, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint61__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(61);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(61, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint62__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(62);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(62, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint62__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(62);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(62, value);
            }
#pragma warning restore CS0618
        }

        public AnimationRootNode BlendPoint63__node
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointNode(63);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                _AddBlendPoint(63, value);
            }
#pragma warning restore CS0618
        }

        public float BlendPoint63__pos
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetBlendPointPosition(63);
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetBlendPointPosition(63, value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The blend space's axis's lower limit for the points' position. See <see cref="Godot.AnimationNodeBlendSpace1D.AddBlendPoint"/>.</para>
        /// </summary>
        public float MinSpace
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMinSpace();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMinSpace(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>The blend space's axis's upper limit for the points' position. See <see cref="Godot.AnimationNodeBlendSpace1D.AddBlendPoint"/>.</para>
        /// </summary>
        public float MaxSpace
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetMaxSpace();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetMaxSpace(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Position increment to snap to when moving a point on the axis.</para>
        /// </summary>
        public float Snap
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetSnap();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetSnap(value);
            }
#pragma warning restore CS0618
        }

        /// <summary>
        /// <para>Label of the virtual axis of the blend space.</para>
        /// </summary>
        public string ValueLabel
        {
            get
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                return GetValueLabel();
            }
#pragma warning restore CS0618
            set
#pragma warning disable CS0618 // Disable warning about obsolete method
            {
                SetValueLabel(value);
            }
#pragma warning restore CS0618
        }

        private const string nativeName = "AnimationNodeBlendSpace1D";

        public AnimationNodeBlendSpace1D() : this(true)
        {
            if (ptr == IntPtr.Zero)
                ptr = NativeCalls.godot_icall_AnimationNodeBlendSpace1D_Ctor(this);
        }

        internal AnimationNodeBlendSpace1D(bool memoryOwn) : base(memoryOwn) {}

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_0 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "add_blend_point");

        /// <summary>
        /// <para>Adds a new point that represents a <c>node</c> on the virtual axis at a given position set by <c>pos</c>. You can insert it at a specific index using the <c>at_index</c> argument. If you use the default value for <c>at_index</c>, the point is inserted at the end of the blend points array.</para>
        /// </summary>
        [GodotMethod("add_blend_point")]
        public void AddBlendPoint(AnimationRootNode node, float pos, int atIndex = -1)
        {
            NativeCalls.godot_icall_3_98(method_bind_0, Object.GetPtr(this), Object.GetPtr(node), pos, atIndex);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_1 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_blend_point_position");

        /// <summary>
        /// <para>Updates the position of the point at index <c>point</c> on the blend axis.</para>
        /// </summary>
        [GodotMethod("set_blend_point_position")]
        [Obsolete("SetBlendPointPosition is deprecated. Use the BlendPoint63__pos property instead.")]
        public void SetBlendPointPosition(int point, float pos)
        {
            NativeCalls.godot_icall_2_34(method_bind_1, Object.GetPtr(this), point, pos);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_2 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_blend_point_position");

        /// <summary>
        /// <para>Returns the position of the point at index <c>point</c>.</para>
        /// </summary>
        [GodotMethod("get_blend_point_position")]
        [Obsolete("GetBlendPointPosition is deprecated. Use the BlendPoint63__pos property instead.")]
        public float GetBlendPointPosition(int point)
        {
            return NativeCalls.godot_icall_1_12(method_bind_2, Object.GetPtr(this), point);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_3 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_blend_point_node");

        /// <summary>
        /// <para>Changes the <see cref="Godot.AnimationNode"/> referenced by the point at index <c>point</c>.</para>
        /// </summary>
        [GodotMethod("set_blend_point_node")]
        public void SetBlendPointNode(int point, AnimationRootNode node)
        {
            NativeCalls.godot_icall_2_58(method_bind_3, Object.GetPtr(this), point, Object.GetPtr(node));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_4 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_blend_point_node");

        /// <summary>
        /// <para>Returns the <see cref="Godot.AnimationNode"/> referenced by the point at index <c>point</c>.</para>
        /// </summary>
        [GodotMethod("get_blend_point_node")]
        [Obsolete("GetBlendPointNode is deprecated. Use the BlendPoint63__node property instead.")]
        public AnimationRootNode GetBlendPointNode(int point)
        {
            return NativeCalls.godot_icall_1_99(method_bind_4, Object.GetPtr(this), point);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_5 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "remove_blend_point");

        /// <summary>
        /// <para>Removes the point at index <c>point</c> from the blend axis.</para>
        /// </summary>
        [GodotMethod("remove_blend_point")]
        public void RemoveBlendPoint(int point)
        {
            NativeCalls.godot_icall_1_4(method_bind_5, Object.GetPtr(this), point);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_6 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_blend_point_count");

        /// <summary>
        /// <para>Returns the number of points on the blend axis.</para>
        /// </summary>
        [GodotMethod("get_blend_point_count")]
        public int GetBlendPointCount()
        {
            return NativeCalls.godot_icall_0_5(method_bind_6, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_7 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_min_space");

        [GodotMethod("set_min_space")]
        [Obsolete("SetMinSpace is deprecated. Use the MinSpace property instead.")]
        public void SetMinSpace(float minSpace)
        {
            NativeCalls.godot_icall_1_15(method_bind_7, Object.GetPtr(this), minSpace);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_8 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_min_space");

        [GodotMethod("get_min_space")]
        [Obsolete("GetMinSpace is deprecated. Use the MinSpace property instead.")]
        public float GetMinSpace()
        {
            return NativeCalls.godot_icall_0_14(method_bind_8, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_9 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_max_space");

        [GodotMethod("set_max_space")]
        [Obsolete("SetMaxSpace is deprecated. Use the MaxSpace property instead.")]
        public void SetMaxSpace(float maxSpace)
        {
            NativeCalls.godot_icall_1_15(method_bind_9, Object.GetPtr(this), maxSpace);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_10 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_max_space");

        [GodotMethod("get_max_space")]
        [Obsolete("GetMaxSpace is deprecated. Use the MaxSpace property instead.")]
        public float GetMaxSpace()
        {
            return NativeCalls.godot_icall_0_14(method_bind_10, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_11 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_snap");

        [GodotMethod("set_snap")]
        [Obsolete("SetSnap is deprecated. Use the Snap property instead.")]
        public void SetSnap(float snap)
        {
            NativeCalls.godot_icall_1_15(method_bind_11, Object.GetPtr(this), snap);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_12 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_snap");

        [GodotMethod("get_snap")]
        [Obsolete("GetSnap is deprecated. Use the Snap property instead.")]
        public float GetSnap()
        {
            return NativeCalls.godot_icall_0_14(method_bind_12, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_13 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "set_value_label");

        [GodotMethod("set_value_label")]
        [Obsolete("SetValueLabel is deprecated. Use the ValueLabel property instead.")]
        public void SetValueLabel(string text)
        {
            NativeCalls.godot_icall_1_54(method_bind_13, Object.GetPtr(this), text);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_14 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "get_value_label");

        [GodotMethod("get_value_label")]
        [Obsolete("GetValueLabel is deprecated. Use the ValueLabel property instead.")]
        public string GetValueLabel()
        {
            return NativeCalls.godot_icall_0_6(method_bind_14, Object.GetPtr(this));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IntPtr method_bind_15 = Object.godot_icall_Object_ClassDB_get_method(nativeName, "_add_blend_point");

        [Obsolete("_AddBlendPoint is deprecated. Use the BlendPoint63__node property instead.")]
        internal void _AddBlendPoint(int index, AnimationRootNode node)
        {
            NativeCalls.godot_icall_2_58(method_bind_15, Object.GetPtr(this), index, Object.GetPtr(node));
        }
    }
}

#pragma warning restore CS1591
#pragma warning restore CS1573
