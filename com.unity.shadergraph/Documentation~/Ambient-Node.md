## Description

Provides access to the Scene's **Ambient** color values. When Environment Lighting Source is set to **Gradient** [Port](Port.md) **Color/Sky** returns the value **Sky Color**. When Environment Lighting Source is set to **Color** [Port](Port.md) **Color/Sky** returns the value **Ambient Color**. [Ports](Port.md) **Equator** and **Ground** always return the values **Equator Color** and **Ground Color** regardless of the current Environment Lighting Source.

Note: Values of this [Node](Node.md) are only updated when entering Play mode or saving the current Scene/Project.

## Ports

| Name        | Direction           | Type  | Binding | Description |
|:------------ |:-------------|:-----|:---|:---|
| Color/Sky    | Output | Vector 3 | None | Color (Color) or Sky (Gradient) color value |
| Equator      | Output | Vector 3 | None | Equator (Gradient) color value |
| Ground       | Output | Vector 3 | None | Ground (Gradient) color value |

## Shader Code

```
float3 ColorSky = unity_AmbientSky;
float3 Equator = unity_AmbientEquator;
float3 Ground = unity_AmbientGround;
```