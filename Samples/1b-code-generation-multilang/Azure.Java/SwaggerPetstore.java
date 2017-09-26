/**
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package cowstore;

import com.microsoft.azure.AzureClient;
import com.microsoft.rest.RestClient;
import com.microsoft.rest.ServiceCallback;
import com.microsoft.rest.ServiceFuture;
import com.microsoft.rest.ServiceResponse;
import com.microsoft.rest.ServiceResponseWithHeaders;
import cowstore.models.ErrorException;
import cowstore.models.ListPetsHeaders;
import cowstore.models.Pet;
import java.io.IOException;
import java.util.List;
import rx.Observable;

/**
 * The interface for SwaggerPetstore class.
 */
public interface SwaggerPetstore {
    /**
     * Gets the REST client.
     *
     * @return the {@link RestClient} object.
    */
    RestClient restClient();

    /**
     * Gets the {@link AzureClient} used for long running operations.
     * @return the azure client;
     */
    AzureClient getAzureClient();

    /**
     * Gets the User-Agent header for the client.
     *
     * @return the user agent string.
     */
    String userAgent();

    /**
     * Gets Gets or sets the preferred language for the response..
     *
     * @return the acceptLanguage value.
     */
    String acceptLanguage();

    /**
     * Sets Gets or sets the preferred language for the response..
     *
     * @param acceptLanguage the acceptLanguage value.
     * @return the service client itself
     */
    SwaggerPetstore withAcceptLanguage(String acceptLanguage);

    /**
     * Gets Gets or sets the retry timeout in seconds for Long Running Operations. Default value is 30..
     *
     * @return the longRunningOperationRetryTimeout value.
     */
    int longRunningOperationRetryTimeout();

    /**
     * Sets Gets or sets the retry timeout in seconds for Long Running Operations. Default value is 30..
     *
     * @param longRunningOperationRetryTimeout the longRunningOperationRetryTimeout value.
     * @return the service client itself
     */
    SwaggerPetstore withLongRunningOperationRetryTimeout(int longRunningOperationRetryTimeout);

    /**
     * Gets When set to true a unique x-ms-client-request-id value is generated and included in each request. Default is true..
     *
     * @return the generateClientRequestId value.
     */
    boolean generateClientRequestId();

    /**
     * Sets When set to true a unique x-ms-client-request-id value is generated and included in each request. Default is true..
     *
     * @param generateClientRequestId the generateClientRequestId value.
     * @return the service client itself
     */
    SwaggerPetstore withGenerateClientRequestId(boolean generateClientRequestId);

    /**
     * List all pets.
     *
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @throws ErrorException thrown if the request is rejected by server
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent
     * @return the List&lt;Pet&gt; object if successful.
     */
    List<Pet> listPets();

    /**
     * List all pets.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceFuture} object
     */
    ServiceFuture<List<Pet>> listPetsAsync(final ServiceCallback<List<Pet>> serviceCallback);

    /**
     * List all pets.
     *
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the observable to the List&lt;Pet&gt; object
     */
    Observable<List<Pet>> listPetsAsync();

    /**
     * List all pets.
     *
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the observable to the List&lt;Pet&gt; object
     */
    Observable<ServiceResponseWithHeaders<List<Pet>, ListPetsHeaders>> listPetsWithServiceResponseAsync();
    /**
     * List all pets.
     *
     * @param limit How many items to return at one time (max 100)
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @throws ErrorException thrown if the request is rejected by server
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent
     * @return the List&lt;Pet&gt; object if successful.
     */
    List<Pet> listPets(Integer limit);

    /**
     * List all pets.
     *
     * @param limit How many items to return at one time (max 100)
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceFuture} object
     */
    ServiceFuture<List<Pet>> listPetsAsync(Integer limit, final ServiceCallback<List<Pet>> serviceCallback);

    /**
     * List all pets.
     *
     * @param limit How many items to return at one time (max 100)
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the observable to the List&lt;Pet&gt; object
     */
    Observable<List<Pet>> listPetsAsync(Integer limit);

    /**
     * List all pets.
     *
     * @param limit How many items to return at one time (max 100)
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the observable to the List&lt;Pet&gt; object
     */
    Observable<ServiceResponseWithHeaders<List<Pet>, ListPetsHeaders>> listPetsWithServiceResponseAsync(Integer limit);

    /**
     * Create a pet.
     *
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @throws ErrorException thrown if the request is rejected by server
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent
     */
    void createPets();

    /**
     * Create a pet.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceFuture} object
     */
    ServiceFuture<Void> createPetsAsync(final ServiceCallback<Void> serviceCallback);

    /**
     * Create a pet.
     *
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceResponse} object if successful.
     */
    Observable<Void> createPetsAsync();

    /**
     * Create a pet.
     *
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceResponse} object if successful.
     */
    Observable<ServiceResponse<Void>> createPetsWithServiceResponseAsync();

    /**
     * Info for a specific pet.
     *
     * @param petId The id of the pet to retrieve
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @throws ErrorException thrown if the request is rejected by server
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent
     * @return the List&lt;Pet&gt; object if successful.
     */
    List<Pet> showPetById(String petId);

    /**
     * Info for a specific pet.
     *
     * @param petId The id of the pet to retrieve
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceFuture} object
     */
    ServiceFuture<List<Pet>> showPetByIdAsync(String petId, final ServiceCallback<List<Pet>> serviceCallback);

    /**
     * Info for a specific pet.
     *
     * @param petId The id of the pet to retrieve
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the observable to the List&lt;Pet&gt; object
     */
    Observable<List<Pet>> showPetByIdAsync(String petId);

    /**
     * Info for a specific pet.
     *
     * @param petId The id of the pet to retrieve
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the observable to the List&lt;Pet&gt; object
     */
    Observable<ServiceResponse<List<Pet>>> showPetByIdWithServiceResponseAsync(String petId);

}
