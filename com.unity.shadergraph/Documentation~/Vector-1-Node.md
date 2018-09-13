## Description

Defines a **Vector 1** value in the shader. If [Port](Port.md) **X** is not connected with an [Edge](Edge.md) this [Node](Node.md) defines a constant **Vector 1**.

## Ports

| Name        | Direction           | Type  | Binding | Description |
|:------------ |:-------------|:-----|:---|:---|
| X      | Input | Vector 1 | None | Input x component value |
| Out | Output      |    Vector 1 | None | Output value |

## Shader Code

```
float Out = X;
```