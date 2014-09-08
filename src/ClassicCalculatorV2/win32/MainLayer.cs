using CocosSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ClassicCalculator
{
    class MainLayer : CCLayer
    {

        public MainLayer()
        {

        }

        public void ConvertToControls(FileData fileData)
        {
            RemoveAllChildren();
            //PanelContainer.Controls.Clear();
            //PanelContainer.Height = fileData.ResolutionHeight;
            //PanelContainer.Width = fileData.ResolutionWidth;
            foreach (var item in fileData.Elements)
                AddCustomControl(item);
        }

        List<CCSprite> images = new List<CCSprite>();

        private void AddCustomControl(CustomElement element)
        {
            var filename =  Path.GetFileName(element.FileName);

            CCSprite tmp = new CCSprite(filename);

            tmp.Position = new CCPoint((float)element.X + tmp.ContentSize.Width * .5f,
                (Window.WindowSizeInPixels.Height - (float)element.Y));

            AddChild(tmp);
        }

        protected override void AddedToScene()
        {
            base.AddedToScene();

			if (ResourcesLoader.Instance.HasFileToLoad)
			{
				FileData elemento = XmlSerialization.ReadFromFile<FileData>(string.Format(Path.Combine("Content",ResourcesLoader.Instance.FirstFile)));
				ConvertToControls(elemento);
			}
        

        }

    }
}
