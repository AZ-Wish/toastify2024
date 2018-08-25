﻿using System;
using System.Windows.Input;
using JetBrains.Annotations;
using log4net;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Toastify.DI;
using ToastifyAPI.Logic.Interfaces;
using ToastifyAPI.Model.Interfaces;
using MouseAction = ToastifyAPI.Core.MouseAction;

namespace Toastify.Model
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class MouseHookHotkey : Hotkey, IMouseHookHotkey
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(MouseHookHotkey));

        private MouseAction? _mouseButton;
        private bool isValid;

        #region Public Properties

        [PropertyDependency]
        public IMouseHookHotkeyVisitor HotkeyVisitor { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include, NullValueHandling = NullValueHandling.Include)]
        [JsonConverter(typeof(StringEnumConverter))]
        public MouseAction? MouseButton
        {
            get { return this._mouseButton; }
            set
            {
                if (this._mouseButton != value)
                {
                    this._mouseButton = value;
                    this.CheckIfValid();
                    this.OnPropertyChanged();
                }
            }
        }

        /// <inheritdoc />
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        [JsonConverter(typeof(StringEnumConverter))]
        public override ModifierKeys Modifiers
        {
            get { return base.Modifiers; }
            set
            {
                if (base.Modifiers != value)
                {
                    base.Modifiers = value;
                    this.CheckIfValid();
                    this.OnPropertyChanged();
                }
            }
        }

        /// <inheritdoc />
        [JsonIgnore]
        public override string HumanReadableKey
        {
            get
            {
                string alt = this.Modifiers.HasFlag(ModifierKeys.Alt) ? "Alt+" : string.Empty;
                string ctlr = this.Modifiers.HasFlag(ModifierKeys.Control) ? "Ctrl+" : string.Empty;
                string shift = this.Modifiers.HasFlag(ModifierKeys.Shift) ? "Shift+" : string.Empty;
                string win = this.Modifiers.HasFlag(ModifierKeys.Windows) ? "Win+" : string.Empty;
                return $"{alt}{ctlr}{shift}{win}{this.MouseButton.ToString()}";
            }
        }

        #endregion

        /// <inheritdoc />
        public MouseHookHotkey()
        {
        }

        /// <inheritdoc />
        public MouseHookHotkey(IAction action) : base(action)
        {
        }

        /// <inheritdoc />
        public MouseHookHotkey([NotNull] IHotkey hotkey) : base(hotkey)
        {
        }

        public MouseHookHotkey([NotNull] MouseHookHotkey hotkey) : base(hotkey)
        {
            if (hotkey == null)
                throw new ArgumentNullException(nameof(hotkey));

            this._mouseButton = hotkey._mouseButton;
            this.isValid = hotkey.isValid;

            this.HotkeyVisitor = hotkey.HotkeyVisitor;
        }

        /// <inheritdoc />
        protected override void InitInternal()
        {
            if (this.HotkeyVisitor != null)
            {
                // If we're not enabled shut everything down asap
                if (!this.Enabled || !this.Active)
                {
                    this.HotkeyVisitor.UnregisterHook(this);

                    // May not be false if !Enabled
                    this._active = false;
                    return;
                }

                if (!this.MouseButton.HasValue)
                    return;

                this.HotkeyVisitor.RegisterHook(this);
            }
            else
                logger.Warn($"{nameof(this.HotkeyVisitor)} is null!");
        }

        /// <inheritdoc />
        public override bool IsValid()
        {
            return this.isValid;
        }

        protected virtual void CheckIfValid()
        {
            if (!this.MouseButton.HasValue)
            {
                this.isValid = false;
                this.InvalidReason = "You must select a valid mouse button for your hotkey combination";
            }
            else if ((this.MouseButton.Value == MouseAction.MWheelUp || this.MouseButton.Value == MouseAction.MWheelDown) && this.Modifiers == ModifierKeys.None)
            {
                this.isValid = false;
                this.InvalidReason = $"You must use at leat one modifier key with {this.MouseButton.Value}";
            }
            else if (this.MouseButton.Value != MouseAction.XButton1 && this.MouseButton.Value != MouseAction.XButton2 &&
                     this.MouseButton.Value != MouseAction.MWheelUp && this.MouseButton.Value != MouseAction.MWheelDown)
            {
                this.isValid = false;
                this.InvalidReason = $"You can't use the {this.MouseButton.Value} mouse button in a hotkey combination";
            }
            else
            {
                this.isValid = true;
                this.InvalidReason = string.Empty;
            }
        }

        /// <inheritdoc />
        public override IHotkeyVisitor GetVisitor()
        {
            return this.HotkeyVisitor;
        }

        /// <inheritdoc />
        protected override void DispatchInternal(IHotkeyVisitor hotkeyVisitor)
        {
            if (hotkeyVisitor is IMouseHookHotkeyVisitor mouseHookHotkeyVisitor)
                mouseHookHotkeyVisitor.Visit(this);
        }

        /// <inheritdoc />
        protected override void DisposeInternal()
        {
            if (this.HotkeyVisitor != null)
                this.HotkeyVisitor.UnregisterHook(this);
            else
                logger.Warn($"{nameof(this.HotkeyVisitor)} is null!");
        }
    }
}