/*
 * Ory APIs
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.30
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package sh.ory.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.time.OffsetDateTime;
import java.util.UUID;
import sh.ory.model.AuthenticatorAssuranceLevel;
import sh.ory.model.IdentityCredentialsType;
import sh.ory.model.UiContainer;

/**
 * This object represents a login flow. A login flow is initiated at the \&quot;Initiate Login API / Browser Flow\&quot; endpoint by a client.  Once a login flow is completed successfully, a session cookie or session token will be issued.
 */
@ApiModel(description = "This object represents a login flow. A login flow is initiated at the \"Initiate Login API / Browser Flow\" endpoint by a client.  Once a login flow is completed successfully, a session cookie or session token will be issued.")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-11-29T12:53:23.012250882Z[Etc/UTC]")
public class SelfServiceLoginFlow {
  public static final String SERIALIZED_NAME_ACTIVE = "active";
  @SerializedName(SERIALIZED_NAME_ACTIVE)
  private IdentityCredentialsType active;

  public static final String SERIALIZED_NAME_CREATED_AT = "created_at";
  @SerializedName(SERIALIZED_NAME_CREATED_AT)
  private OffsetDateTime createdAt;

  public static final String SERIALIZED_NAME_EXPIRES_AT = "expires_at";
  @SerializedName(SERIALIZED_NAME_EXPIRES_AT)
  private OffsetDateTime expiresAt;

  public static final String SERIALIZED_NAME_ID = "id";
  @SerializedName(SERIALIZED_NAME_ID)
  private UUID id;

  public static final String SERIALIZED_NAME_ISSUED_AT = "issued_at";
  @SerializedName(SERIALIZED_NAME_ISSUED_AT)
  private OffsetDateTime issuedAt;

  public static final String SERIALIZED_NAME_REFRESH = "refresh";
  @SerializedName(SERIALIZED_NAME_REFRESH)
  private Boolean refresh;

  public static final String SERIALIZED_NAME_REQUEST_URL = "request_url";
  @SerializedName(SERIALIZED_NAME_REQUEST_URL)
  private String requestUrl;

  public static final String SERIALIZED_NAME_REQUESTED_AAL = "requested_aal";
  @SerializedName(SERIALIZED_NAME_REQUESTED_AAL)
  private AuthenticatorAssuranceLevel requestedAal;

  public static final String SERIALIZED_NAME_RETURN_TO = "return_to";
  @SerializedName(SERIALIZED_NAME_RETURN_TO)
  private String returnTo;

  public static final String SERIALIZED_NAME_TYPE = "type";
  @SerializedName(SERIALIZED_NAME_TYPE)
  private String type;

  public static final String SERIALIZED_NAME_UI = "ui";
  @SerializedName(SERIALIZED_NAME_UI)
  private UiContainer ui;

  public static final String SERIALIZED_NAME_UPDATED_AT = "updated_at";
  @SerializedName(SERIALIZED_NAME_UPDATED_AT)
  private OffsetDateTime updatedAt;


  public SelfServiceLoginFlow active(IdentityCredentialsType active) {
    
    this.active = active;
    return this;
  }

   /**
   * Get active
   * @return active
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public IdentityCredentialsType getActive() {
    return active;
  }


  public void setActive(IdentityCredentialsType active) {
    this.active = active;
  }


  public SelfServiceLoginFlow createdAt(OffsetDateTime createdAt) {
    
    this.createdAt = createdAt;
    return this;
  }

   /**
   * CreatedAt is a helper struct field for gobuffalo.pop.
   * @return createdAt
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "CreatedAt is a helper struct field for gobuffalo.pop.")

  public OffsetDateTime getCreatedAt() {
    return createdAt;
  }


  public void setCreatedAt(OffsetDateTime createdAt) {
    this.createdAt = createdAt;
  }


  public SelfServiceLoginFlow expiresAt(OffsetDateTime expiresAt) {
    
    this.expiresAt = expiresAt;
    return this;
  }

   /**
   * ExpiresAt is the time (UTC) when the flow expires. If the user still wishes to log in, a new flow has to be initiated.
   * @return expiresAt
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "ExpiresAt is the time (UTC) when the flow expires. If the user still wishes to log in, a new flow has to be initiated.")

  public OffsetDateTime getExpiresAt() {
    return expiresAt;
  }


  public void setExpiresAt(OffsetDateTime expiresAt) {
    this.expiresAt = expiresAt;
  }


  public SelfServiceLoginFlow id(UUID id) {
    
    this.id = id;
    return this;
  }

   /**
   * Get id
   * @return id
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public UUID getId() {
    return id;
  }


  public void setId(UUID id) {
    this.id = id;
  }


  public SelfServiceLoginFlow issuedAt(OffsetDateTime issuedAt) {
    
    this.issuedAt = issuedAt;
    return this;
  }

   /**
   * IssuedAt is the time (UTC) when the flow started.
   * @return issuedAt
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "IssuedAt is the time (UTC) when the flow started.")

  public OffsetDateTime getIssuedAt() {
    return issuedAt;
  }


  public void setIssuedAt(OffsetDateTime issuedAt) {
    this.issuedAt = issuedAt;
  }


  public SelfServiceLoginFlow refresh(Boolean refresh) {
    
    this.refresh = refresh;
    return this;
  }

   /**
   * Refresh stores whether this login flow should enforce re-authentication.
   * @return refresh
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Refresh stores whether this login flow should enforce re-authentication.")

  public Boolean getRefresh() {
    return refresh;
  }


  public void setRefresh(Boolean refresh) {
    this.refresh = refresh;
  }


  public SelfServiceLoginFlow requestUrl(String requestUrl) {
    
    this.requestUrl = requestUrl;
    return this;
  }

   /**
   * RequestURL is the initial URL that was requested from Ory Kratos. It can be used to forward information contained in the URL&#39;s path or query for example.
   * @return requestUrl
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "RequestURL is the initial URL that was requested from Ory Kratos. It can be used to forward information contained in the URL's path or query for example.")

  public String getRequestUrl() {
    return requestUrl;
  }


  public void setRequestUrl(String requestUrl) {
    this.requestUrl = requestUrl;
  }


  public SelfServiceLoginFlow requestedAal(AuthenticatorAssuranceLevel requestedAal) {
    
    this.requestedAal = requestedAal;
    return this;
  }

   /**
   * Get requestedAal
   * @return requestedAal
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public AuthenticatorAssuranceLevel getRequestedAal() {
    return requestedAal;
  }


  public void setRequestedAal(AuthenticatorAssuranceLevel requestedAal) {
    this.requestedAal = requestedAal;
  }


  public SelfServiceLoginFlow returnTo(String returnTo) {
    
    this.returnTo = returnTo;
    return this;
  }

   /**
   * ReturnTo contains the requested return_to URL.
   * @return returnTo
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "ReturnTo contains the requested return_to URL.")

  public String getReturnTo() {
    return returnTo;
  }


  public void setReturnTo(String returnTo) {
    this.returnTo = returnTo;
  }


  public SelfServiceLoginFlow type(String type) {
    
    this.type = type;
    return this;
  }

   /**
   * The flow type can either be &#x60;api&#x60; or &#x60;browser&#x60;.
   * @return type
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "The flow type can either be `api` or `browser`.")

  public String getType() {
    return type;
  }


  public void setType(String type) {
    this.type = type;
  }


  public SelfServiceLoginFlow ui(UiContainer ui) {
    
    this.ui = ui;
    return this;
  }

   /**
   * Get ui
   * @return ui
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "")

  public UiContainer getUi() {
    return ui;
  }


  public void setUi(UiContainer ui) {
    this.ui = ui;
  }


  public SelfServiceLoginFlow updatedAt(OffsetDateTime updatedAt) {
    
    this.updatedAt = updatedAt;
    return this;
  }

   /**
   * UpdatedAt is a helper struct field for gobuffalo.pop.
   * @return updatedAt
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "UpdatedAt is a helper struct field for gobuffalo.pop.")

  public OffsetDateTime getUpdatedAt() {
    return updatedAt;
  }


  public void setUpdatedAt(OffsetDateTime updatedAt) {
    this.updatedAt = updatedAt;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SelfServiceLoginFlow selfServiceLoginFlow = (SelfServiceLoginFlow) o;
    return Objects.equals(this.active, selfServiceLoginFlow.active) &&
        Objects.equals(this.createdAt, selfServiceLoginFlow.createdAt) &&
        Objects.equals(this.expiresAt, selfServiceLoginFlow.expiresAt) &&
        Objects.equals(this.id, selfServiceLoginFlow.id) &&
        Objects.equals(this.issuedAt, selfServiceLoginFlow.issuedAt) &&
        Objects.equals(this.refresh, selfServiceLoginFlow.refresh) &&
        Objects.equals(this.requestUrl, selfServiceLoginFlow.requestUrl) &&
        Objects.equals(this.requestedAal, selfServiceLoginFlow.requestedAal) &&
        Objects.equals(this.returnTo, selfServiceLoginFlow.returnTo) &&
        Objects.equals(this.type, selfServiceLoginFlow.type) &&
        Objects.equals(this.ui, selfServiceLoginFlow.ui) &&
        Objects.equals(this.updatedAt, selfServiceLoginFlow.updatedAt);
  }

  @Override
  public int hashCode() {
    return Objects.hash(active, createdAt, expiresAt, id, issuedAt, refresh, requestUrl, requestedAal, returnTo, type, ui, updatedAt);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SelfServiceLoginFlow {\n");
    sb.append("    active: ").append(toIndentedString(active)).append("\n");
    sb.append("    createdAt: ").append(toIndentedString(createdAt)).append("\n");
    sb.append("    expiresAt: ").append(toIndentedString(expiresAt)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    issuedAt: ").append(toIndentedString(issuedAt)).append("\n");
    sb.append("    refresh: ").append(toIndentedString(refresh)).append("\n");
    sb.append("    requestUrl: ").append(toIndentedString(requestUrl)).append("\n");
    sb.append("    requestedAal: ").append(toIndentedString(requestedAal)).append("\n");
    sb.append("    returnTo: ").append(toIndentedString(returnTo)).append("\n");
    sb.append("    type: ").append(toIndentedString(type)).append("\n");
    sb.append("    ui: ").append(toIndentedString(ui)).append("\n");
    sb.append("    updatedAt: ").append(toIndentedString(updatedAt)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

