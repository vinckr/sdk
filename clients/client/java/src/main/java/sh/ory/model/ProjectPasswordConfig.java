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

/**
 * ProjectPasswordConfig
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-11-29T12:53:23.012250882Z[Etc/UTC]")
public class ProjectPasswordConfig {
  public static final String SERIALIZED_NAME_ENABLED = "enabled";
  @SerializedName(SERIALIZED_NAME_ENABLED)
  private Boolean enabled;

  public static final String SERIALIZED_NAME_REVOKE_ACTIVE_SESSIONS = "revoke_active_sessions";
  @SerializedName(SERIALIZED_NAME_REVOKE_ACTIVE_SESSIONS)
  private Boolean revokeActiveSessions;


  public ProjectPasswordConfig enabled(Boolean enabled) {
    
    this.enabled = enabled;
    return this;
  }

   /**
   * Set to true to enable the password authentication method.
   * @return enabled
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Set to true to enable the password authentication method.")

  public Boolean getEnabled() {
    return enabled;
  }


  public void setEnabled(Boolean enabled) {
    this.enabled = enabled;
  }


  public ProjectPasswordConfig revokeActiveSessions(Boolean revokeActiveSessions) {
    
    this.revokeActiveSessions = revokeActiveSessions;
    return this;
  }

   /**
   * Set to true to remove active sessions when the users logs in.
   * @return revokeActiveSessions
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Set to true to remove active sessions when the users logs in.")

  public Boolean getRevokeActiveSessions() {
    return revokeActiveSessions;
  }


  public void setRevokeActiveSessions(Boolean revokeActiveSessions) {
    this.revokeActiveSessions = revokeActiveSessions;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ProjectPasswordConfig projectPasswordConfig = (ProjectPasswordConfig) o;
    return Objects.equals(this.enabled, projectPasswordConfig.enabled) &&
        Objects.equals(this.revokeActiveSessions, projectPasswordConfig.revokeActiveSessions);
  }

  @Override
  public int hashCode() {
    return Objects.hash(enabled, revokeActiveSessions);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ProjectPasswordConfig {\n");
    sb.append("    enabled: ").append(toIndentedString(enabled)).append("\n");
    sb.append("    revokeActiveSessions: ").append(toIndentedString(revokeActiveSessions)).append("\n");
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

