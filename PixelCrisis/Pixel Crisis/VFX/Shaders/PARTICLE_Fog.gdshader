shader_type canvas_item;                             

uniform vec4 fill_color : hint_color = vec4(1.0,0.0,0.0,1.0); 
uniform float scale = 10.0;                            
uniform float amp = 0.8;                               
uniform float k = 1.0;                                
uniform float m = 1.1;                                 
uniform float thickness = 0.02;                        
uniform float inner_radius = 0.08;                     
uniform float border_fade = 0.003;                    

void fragment() {
    vec2 center = vec2(0.5, 0.5);                      
    vec2 pos = (UV - center) * scale;                  
    float theta = atan(pos.y, pos.x);                  
    if (theta < 0.0) theta += 6.28318530718;           
    float r_pos = length(pos);                         

    float r_curve = amp * (cos(k * theta) + cos(m * theta) / m) * scale;

    float r_curve2 = amp * (sin(k * theta) - sin(m * theta) / m) * scale;

    float r_target = max(abs(r_curve), abs(r_curve2));

    float dist = abs(r_pos - r_target);

    float line_mask = smoothstep(thickness + border_fade, thickness - border_fade, dist);

    float center_mask = smoothstep(inner_radius, inner_radius - border_fade, r_pos);

    float alpha = max(line_mask, center_mask);

    COLOR = vec4(fill_color.rgb, fill_color.a * alpha);
}
