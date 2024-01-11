#version 330 core

out vec4 fragColor;

in vec2 TexCoord;

uniform sampler2D texture0;
uniform sampler2D texture1;

void main(){
    fragColor = mix(texture(texture0, TexCoord), texture(texture1, TexCoord), 0.2);
}