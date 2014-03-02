﻿using System;
using MonoMac.AppKit;
using MonoMac.Foundation;
using Timelapse_API;
using Timelapse_UI;
using MessageTranslation;
using System.Collections;

namespace LapseStudioMacUI
{
	public class CocoaUI : LapseStudioUI
	{
		MainWindowController mw;
		TableDataSource TableSource = new TableDataSource();

		public CocoaUI(MainWindowController win, MessageBox MsgBox, FileDialog FDialog) : base(MsgBox, FDialog)
		{
			mw = win;
			Init(Platform.MacOSX);
			mw.PublicMainTable.DataSource = TableSource;

			ProjectManager.BrightnessCalculated += CurrentProject_BrightnessCalculated;
			ProjectManager.FramesLoaded += CurrentProject_FramesLoaded;
			ProjectManager.ProgressChanged += CurrentProject_ProgressChanged;
			ProjectManager.WorkDone += CurrentProject_WorkDone;
		}

		#region Methods

		public override void Dispose()
		{
		}

		public override void ResetMovement()
		{
			/*mw.XmovScale.Value = 0;
			mw.YmovScale.Value = 0;
			if (mw.fixThumb.Pixbuf != null) { mw.fixThumb.Pixbuf.Dispose(); }
			if (mw.fixThumb.Pixbuf != null) { mw.fixThumb.Pixbuf.Dispose(); }*/
		}

		public override void InitMovement()
		{
			/*mw.alignThumb.Pixbuf = ProjectManager.CurrentProject.Frames[1].Thumb.Pixbuf;
			mw.fixThumb.Pixbuf = ProjectManager.CurrentProject.Frames[0].Thumb.Pixbuf;

			double factor = (double)mw.fixThumb.Pixbuf.Width / (double)mw.fixThumb.Pixbuf.Height;
			mw.fixThumb.Pixbuf = mw.fixThumb.Pixbuf.ScaleSimple(160, (int)(160 / factor), Gdk.InterpType.Bilinear);
			mw.alignThumb.Pixbuf = mw.alignThumb.Pixbuf.ScaleSimple(160, (int)(160 / factor), Gdk.InterpType.Bilinear);

			mw.alignThumb.Pixbuf = mw.alignThumb.Pixbuf.AddAlpha(false, 0, 0, 0);
			SetOpacity(mw.alignThumb.Pixbuf, 128);

			int nl = (mw.fixThumb.Pixbuf.Width * 25 / 100) + (mw.fixThumb.Pixbuf.Width / 2);
			int nh = (mw.fixThumb.Pixbuf.Height * 25 / 100) + (mw.fixThumb.Pixbuf.Height / 2);

			mw.FixAlignment.LeftPadding = (uint)nl;
			mw.FixAlignment.TopPadding = (uint)nh;
			mw.MoveAlignment.LeftPadding = (uint)nl;
			mw.MoveAlignment.TopPadding = (uint)nh;*/
		}


		public override void InvokeUI(Action action)
		{
			mw.InvokeOnMainThread(new NSAction(delegate { action(); } ));
		}

		public override void QuitApplication()
		{
			mw.Close();
		}

		public override void InitOpenedProject()
		{
			UpdateTable();
			InitMovement();
			/*mw.FileTree.SetCursor(TreeViewHandler.GetFirstPath(), mw.FileTree.Columns[0], false);
			mw.FrameSelectScale.SetRange(0, ProjectManager.CurrentProject.Frames.Count - 1);
			OnFrameSelectScaleValueChanged(null, null);

			mw.MainNotebook.CurrentPage = (int)TabLocation.Graph;
			MainGraph.SetFromLoading(Storage.Points, Storage.SelectedPoint);
			mw.MainNotebook.CurrentPage = (int)TabLocation.Filelist;

			mw.CalcTypeCoBox.Active = Storage.CalcTypeCoBoxValue;
			mw.BrightnessScale.Value = Storage.BrightnessScaleValue;*/
		}

		public override void ResetProgress()
		{
			InvokeUI(() =>
			{
				mw.PublicMainProgressBar.DoubleValue = 0;
			});
		}

		public override void ResetPictureBoxes()
		{
			//mw.alignThumb.Pixbuf = null;
			//mw.fixThumb.Pixbuf = null;
			mw.PublicThumbEditView.Image = null;
			mw.PublicThumbViewList.Image = null;
			mw.PublicThumbViewGraph.Image = null;
		}

		public override void InitUI()
		{
			mw.PublicMetadataToolItem.Enabled = (LSSettings.UsedProgram != ProjectType.CameraRaw) ? false : true;
			//mw.FileTree = TreeViewHandler.Init(mw.FileTree);
			//mw.CalcTypeCoBox.Active = (int)LSSettings.BrCalcType;
		}

		public override void ClearTable()
		{
			TableSource.Clear();
			mw.PublicMainTable.ReloadData();
		}

		public override void SetTableRow(int Index, ArrayList Values)
		{
			TableSource.Add(Values);
			mw.PublicMainTable.ReloadData();
		}

		#endregion

		#region Eventhandling

		private void CurrentProject_WorkDone(object sender, WorkFinishedEventArgs e)
		{
			try
			{
				mw.InvokeOnMainThread(delegate
				{
					if (!e.Cancelled)
					{
						switch (e.Topic)
						{
							case Work.ProcessThumbs:
								mw.FrameSelectChanged();
								break;
							case Work.LoadProject:
								InitOpenedProject();
								break;
						}

						mw.PublicStatuslabel.StringValue = Message.GetString(e.Topic.ToString()) + " " + Message.GetString("is done");
					}
					else { mw.PublicStatuslabel.StringValue = Message.GetString(e.Topic.ToString()) + " " + Message.GetString("got cancelled"); }
					ResetProgress();
				});
			}
			catch (Exception ex) { Error.Report("Work finished", ex); }
		}

		private void CurrentProject_ProgressChanged(object sender, ProgressChangeEventArgs e)
		{
			try
			{
				mw.InvokeOnMainThread(delegate
				{
					mw.PublicMainProgressBar.DoubleValue = e.ProgressPercentage / 100d;
					mw.PublicStatuslabel.StringValue = Message.GetString(e.Topic.ToString());
				});
			}
			catch (Exception ex) { Error.Report("Progress changed", ex); }
		}

		private void CurrentProject_FramesLoaded(object sender, WorkFinishedEventArgs e)
		{
			try
			{
				mw.InvokeOnMainThread(delegate
				{
					mw.PublicStatuslabel.StringValue = Message.GetString("Frames loaded");
					UpdateTable();
					InitMovement();
					mw.PublicMainTable.SelectRow(0, true);
					mw.PublicFrameSelectSlider.MinValue = 0;
					mw.PublicFrameSelectSlider.MaxValue = ProjectManager.CurrentProject.Frames.Count - 1;
					mw.FrameSelectChanged();
					ResetProgress();
				});
			}
			catch (Exception ex) { Error.Report("Frames loading finished", ex); }
		}

		private void CurrentProject_BrightnessCalculated(object sender, WorkFinishedEventArgs e)
		{
			try
			{
				mw.InvokeOnMainThread(delegate
				{
					mw.PublicStatuslabel.StringValue = Message.GetString("Brightness calculated");
					UpdateTable();
					ResetProgress();
				});
			}
			catch (Exception ex) { Error.Report("Brightness calculation finished", ex); }
		}

		#endregion

	}
}

