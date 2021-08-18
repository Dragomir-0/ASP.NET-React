import React, { useCallback } from "react";
import { useDropzone } from "react-dropzone";
import { Header, Icon } from "semantic-ui-react";

interface Props {
  setFiles: (files: any) => void;
}

export default function PhotoWidgetDropzone({ setFiles }: Props) {
  const dzStyles = {
    border: "dashed 0.1875em #eee",
    borderColor: "#eee",
    borderRadius: "0.3125em",
    paddingTop: "1.875em",
    textAlign: "center" as "center",
    height: "12.5em",
  };
  const dzActive = {
    borderColor: "green",
  };
  const onDrop = useCallback(
    (acceptedFiles) => {
      setFiles(
        acceptedFiles.map((file: any) =>
          Object.assign(file, {
            preview: URL.createObjectURL(file),
          })
        )
      );
    },
    [setFiles]
  );
  const { getRootProps, getInputProps, isDragActive } = useDropzone({ onDrop });

  return (
    <div
      {...getRootProps()}
      style={isDragActive ? { ...dzStyles, ...dzActive } : { ...dzStyles }}
    >
      <input {...getInputProps()} />
      <Icon name="upload" size="huge" />
      <Header content="Drop image here" />
    </div>
  );
}
