using Core.Scenes;
using System;

namespace Core.Data;

public interface ISceneProvider
{
    SceneNode LoadRecusively();
    ISceneData Load(string sceneId);
}