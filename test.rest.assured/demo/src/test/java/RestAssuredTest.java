import org.testng.annotations.Test;
import io.restassured.RestAssured;
import io.restassured.response.Response;
import static org.testng.Assert.assertEquals;

public class RestAssuredTest {

    @Test
    public void testGetRequest() {
        // Specify base URI
        RestAssured.baseURI = "https://jsonplaceholder.typicode.com";

        // Send GET request to /posts endpoint
        Response response = RestAssured.get("/posts/1");

        // Verify status code
        assertEquals(response.getStatusCode(), 200);

        // Verify response body
        String responseBody = response.getBody().asString();
        System.out.println("Response Body: " + responseBody);

        // Perform additional assertions as needed
        // For example, assert specific fields in the response body
        assertEquals(response.jsonPath().getString("title"), "sunt aut facere repellat provident occaecati excepturi optio reprehenderit");
    }
}
