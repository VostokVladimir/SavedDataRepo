using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScrinShotController : MonoBehaviour
{
    public Camera screenShotCamera;
    

    public void MakeScreenShot()
    {
        int width = this.screenShotCamera.pixelWidth;
        int height = this.screenShotCamera.pixelHeight;
        Texture2D texture = new Texture2D(width, height);
        RenderTexture renderTexture = RenderTexture.GetTemporary(width, height);
        this.screenShotCamera.targetTexture = renderTexture;//целевая рендер текстура куда камера рендерит изображение
        this.screenShotCamera.Render();//единоразовый вызов рендера для снимка сцены
        RenderTexture.active = renderTexture;//необходимо поместить целевую текстуру targetTexture, которую мы брали из архива, обратно, так как теперь очередь главной камеры “рендерить” сцену.
        Rect rect = new Rect(0, 0, width, height);//В переменной targetTexture хранится изображение с новой камеры, пока главная камера еще не успела поместить в эту же переменную свое изображение, необходимо перенести изображение из RenderTexture в обычную текстуру Texture2D.
        texture.ReadPixels(rect, 0, 0);
        texture.Apply();
      // Вопрос: //Как вывести изображение на элемент канваса Radar/Image?
          
    }

}
