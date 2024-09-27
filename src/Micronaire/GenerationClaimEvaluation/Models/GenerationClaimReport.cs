// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
namespace Micronaire.GenerationClaimEvaluation;

/// <summary>
/// Report for evaluating generation using claims.
/// </summary>
public class GenerationClaimReport
{
    /// <summary>
    /// The proportion of claims in response that are entailed in retrieved chunks.
    /// </summary>
    public double Faithfulness { get; set; }

    /// <summary>
    /// The proportion of incorrect claims from relevant chunks.
    /// </summary>
    public double RelevantNoiseSensitivity { get; set; }

    /// <summary>
    /// The proportion of incorrect claims from irrelevant chunks.
    /// </summary>
    public double IrrelevantNoiseSensitivity { get; set; }

    /// <summary>
    /// The proportion of incorrect claims not entailed by any chunk.
    /// </summary>
    public double Hallucination { get; set; }

    /// <summary>
    /// The proportion of correct claims generated by the model itself.
    /// </summary>
    public double SelfKnowledgeScore { get; set; }

    /// <summary>
    /// Ratio of relevant claims in response to those in retrieved chunks.
    /// </summary>
    public double ContextUtilization { get; set; }
}