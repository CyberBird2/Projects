package wondi.example.ToDoList.CorsConfiguration;

import org.springframework.context.annotation.Bean;
import org.springframework.web.servlet.config.annotation.CorsRegistry;
import org.springframework.web.servlet.config.annotation.WebMvcConfigurer;
public class EmployeeCorsConfig {

    @Bean
    public WebMvcConfigurer employeeCorsConfigurer() {
        return new WebMvcConfigurer() {
            @Override
            public void addCorsMappings(CorsRegistry registry) {
                registry.addMapping("/employees")
                        .allowedMethods("GET", "POST", "PUT", "DELETE")
                        .allowedOrigins("http://localhost:4200")

                        .allowedHeaders("*")
                        .allowCredentials(false);

            }
        };
    }

}
