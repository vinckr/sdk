/*
 * ORY Keto
 * Ory Keto is a cloud native access control server providing best-practice patterns (RBAC, ABAC, ACL, AWS IAM Policies, Kubernetes Roles, ...) via REST APIs.
 *
 * The version of the OpenAPI document: v0.7.0-alpha.1
 * Contact: hi@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package sh.ory.keto.api;

import sh.ory.keto.ApiException;
import sh.ory.keto.model.InlineResponse400;
import sh.ory.keto.model.PatchDelta;
import sh.ory.keto.model.RelationQuery;
import org.junit.Test;
import org.junit.Ignore;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for WriteApi
 */
@Ignore
public class WriteApiTest {

    private final WriteApi api = new WriteApi();

    
    /**
     * Create a Relation Tuple
     *
     * Use this endpoint to create a relation tuple.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void createRelationTupleTest() throws ApiException {
        RelationQuery payload = null;
        RelationQuery response = api.createRelationTuple(payload);

        // TODO: test validations
    }
    
    /**
     * Delete a Relation Tuple
     *
     * Use this endpoint to delete a relation tuple.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void deleteRelationTupleTest() throws ApiException {
        String namespace = null;
        String _object = null;
        String relation = null;
        String subjectId = null;
        String subjectSetNamespace = null;
        String subjectSetObject = null;
        String subjectSetRelation = null;
        api.deleteRelationTuple(namespace, _object, relation, subjectId, subjectSetNamespace, subjectSetObject, subjectSetRelation);

        // TODO: test validations
    }
    
    /**
     * Patch Multiple Relation Tuples
     *
     * Use this endpoint to patch one or more relation tuples.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void patchRelationTuplesTest() throws ApiException {
        List<PatchDelta> payload = null;
        api.patchRelationTuples(payload);

        // TODO: test validations
    }
    
}
