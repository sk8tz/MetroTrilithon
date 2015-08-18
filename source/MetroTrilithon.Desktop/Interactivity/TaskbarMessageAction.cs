﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shell;
using Livet.Behaviors.Messaging;
using Livet.Messaging;

namespace MetroTrilithon.Interactivity
{
	public class TaskbarMessageAction : InteractionMessageAction<Window>
	{
		protected override void InvokeAction(InteractionMessage interactionMessage)
		{
			var message = interactionMessage as TaskbarMessage;
			if (message == null) return;

			var taskbarInfo = this.AssociatedObject.TaskbarItemInfo ?? (this.AssociatedObject.TaskbarItemInfo = new TaskbarItemInfo());

			if (message.ProgressState != null)
			{
				taskbarInfo.ProgressState = message.ProgressState.Value;
			}

			if (message.ProgressValue != null)
			{
				taskbarInfo.ProgressValue = message.ProgressValue.Value;
			}

			if (message.Overlay != null)
			{
				taskbarInfo.Overlay = message.Overlay;
			}

			if (message.Description != null)
			{
				taskbarInfo.Description = message.Description;
			}

			if (message.ThumbnailClipMargin != null)
			{
				taskbarInfo.ThumbnailClipMargin = message.ThumbnailClipMargin.Value;
			}

			if (message.ThumbButtonInfos != null)
			{
				taskbarInfo.ThumbButtonInfos = message.ThumbButtonInfos;
			}
		}
	}
}