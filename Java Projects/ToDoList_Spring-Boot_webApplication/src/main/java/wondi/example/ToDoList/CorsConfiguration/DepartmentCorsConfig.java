package wondi.example.ToDoList.CorsConfiguration;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.web.servlet.config.annotation.CorsRegistry;
import org.springframework.web.servlet.config.annotation.WebMvcConfigurer;

@Configuration
public class DepartmentCorsConfig {
    @Bean
    public WebMvcConfigurer  corsConfigurer() {
        return new WebMvcConfigurer() {
            @Override
            public void addCorsMappings(CorsRegistry registry) {
                registry.addMapping("/departments")
                        .allowedMethods("GET", "POST", "PUT","DELETE")
                        .allowedOrigins("http://localhost:4200");

            }
        };
    }

}
