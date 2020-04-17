#version 440

varying vec2 texCoord;

uniform sampler2D diffuse;

out vec4 gl_FragColor;

void main() {
    gl_FragColor = texture2D(diffuse, texCoord0);
}