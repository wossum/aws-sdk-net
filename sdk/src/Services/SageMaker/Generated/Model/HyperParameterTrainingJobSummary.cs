/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specifies summary information about a training job.
    /// </summary>
    public partial class HyperParameterTrainingJobSummary
    {
        private DateTime? _creationTime;
        private string _failureReason;
        private FinalHyperParameterTuningJobObjectiveMetric _finalHyperParameterTuningJobObjectiveMetric;
        private ObjectiveStatus _objectiveStatus;
        private DateTime? _trainingEndTime;
        private string _trainingJobArn;
        private string _trainingJobName;
        private TrainingJobStatus _trainingJobStatus;
        private DateTime? _trainingStartTime;
        private Dictionary<string, string> _tunedHyperParameters = new Dictionary<string, string>();
        private string _tuningJobName;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the training job was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason that the training job failed. 
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property FinalHyperParameterTuningJobObjectiveMetric. 
        /// <para>
        /// The <a>FinalHyperParameterTuningJobObjectiveMetric</a> object that specifies the value
        /// of the objective metric of the tuning job that launched this training job.
        /// </para>
        /// </summary>
        public FinalHyperParameterTuningJobObjectiveMetric FinalHyperParameterTuningJobObjectiveMetric
        {
            get { return this._finalHyperParameterTuningJobObjectiveMetric; }
            set { this._finalHyperParameterTuningJobObjectiveMetric = value; }
        }

        // Check to see if FinalHyperParameterTuningJobObjectiveMetric property is set
        internal bool IsSetFinalHyperParameterTuningJobObjectiveMetric()
        {
            return this._finalHyperParameterTuningJobObjectiveMetric != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectiveStatus. 
        /// <para>
        /// The status of the objective metric for the training job:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Succeeded: The final objective metric for the training job was evaluated by the hyperparameter
        /// tuning job and used in the hyperparameter tuning process.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// Pending: The training job is in progress and evaluation of its final objective metric
        /// is pending.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        /// Failed: The final objective metric for the training job was not evaluated, and was
        /// not used in the hyperparameter tuning process. This typically occurs when the training
        /// job failed or did not emit an objective metric.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ObjectiveStatus ObjectiveStatus
        {
            get { return this._objectiveStatus; }
            set { this._objectiveStatus = value; }
        }

        // Check to see if ObjectiveStatus property is set
        internal bool IsSetObjectiveStatus()
        {
            return this._objectiveStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingEndTime. 
        /// <para>
        /// The date and time that the training job ended.
        /// </para>
        /// </summary>
        public DateTime TrainingEndTime
        {
            get { return this._trainingEndTime.GetValueOrDefault(); }
            set { this._trainingEndTime = value; }
        }

        // Check to see if TrainingEndTime property is set
        internal bool IsSetTrainingEndTime()
        {
            return this._trainingEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrainingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the training job.
        /// </para>
        /// </summary>
        public string TrainingJobArn
        {
            get { return this._trainingJobArn; }
            set { this._trainingJobArn = value; }
        }

        // Check to see if TrainingJobArn property is set
        internal bool IsSetTrainingJobArn()
        {
            return this._trainingJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingJobName. 
        /// <para>
        /// The name of the training job.
        /// </para>
        /// </summary>
        public string TrainingJobName
        {
            get { return this._trainingJobName; }
            set { this._trainingJobName = value; }
        }

        // Check to see if TrainingJobName property is set
        internal bool IsSetTrainingJobName()
        {
            return this._trainingJobName != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingJobStatus. 
        /// <para>
        /// The status of the training job.
        /// </para>
        /// </summary>
        public TrainingJobStatus TrainingJobStatus
        {
            get { return this._trainingJobStatus; }
            set { this._trainingJobStatus = value; }
        }

        // Check to see if TrainingJobStatus property is set
        internal bool IsSetTrainingJobStatus()
        {
            return this._trainingJobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingStartTime. 
        /// <para>
        /// The date and time that the training job started.
        /// </para>
        /// </summary>
        public DateTime TrainingStartTime
        {
            get { return this._trainingStartTime.GetValueOrDefault(); }
            set { this._trainingStartTime = value; }
        }

        // Check to see if TrainingStartTime property is set
        internal bool IsSetTrainingStartTime()
        {
            return this._trainingStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TunedHyperParameters. 
        /// <para>
        /// A list of the hyperparameters for which you specified ranges to search.
        /// </para>
        /// </summary>
        public Dictionary<string, string> TunedHyperParameters
        {
            get { return this._tunedHyperParameters; }
            set { this._tunedHyperParameters = value; }
        }

        // Check to see if TunedHyperParameters property is set
        internal bool IsSetTunedHyperParameters()
        {
            return this._tunedHyperParameters != null && this._tunedHyperParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TuningJobName.
        /// </summary>
        public string TuningJobName
        {
            get { return this._tuningJobName; }
            set { this._tuningJobName = value; }
        }

        // Check to see if TuningJobName property is set
        internal bool IsSetTuningJobName()
        {
            return this._tuningJobName != null;
        }

    }
}