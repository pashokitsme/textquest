using Core.Scenes;
using System;

namespace Core.Data;

public interface ISceneProvider
{
    Node LoadRoot();

    ISceneData Load(string sceneId);
}