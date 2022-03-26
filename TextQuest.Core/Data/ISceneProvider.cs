using Core.Data.Json;
using Core.Scenes;
using System;

namespace Core.Data;

public interface ISceneProvider
{
    List<JsonSceneData> All { get; }
    Node LoadRoot();
    ISceneData Load(string sceneId);
    ISceneData Create(string header, string body, List<JsonAnswerData> answers);
    bool TrySave(ISceneData data);
}